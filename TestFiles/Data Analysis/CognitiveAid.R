## One-way repeated measures ANOVA

# read in a data file now with a third method, voice recognition
srchscrlvce = read.csv("srchscrlvce.csv")
View(srchscrlvce)
srchscrlvce$Subject = factor(srchscrlvce$Subject) # convert to nominal factor
srchscrlvce$Order = factor(srchscrlvce$Order) # convert to nominal factor
summary(srchscrlvce)

# view descriptive statistics by Technique
library(plyr)
ddply(srchscrlvce, ~ Technique, function(data) summary(data$Time))
ddply(srchscrlvce, ~ Technique, summarise, Time.mean=mean(Time), Time.sd=sd(Time))

# graph histograms and boxplot
hist(srchscrlvce[srchscrlvce$Technique == "Search",]$Time)
hist(srchscrlvce[srchscrlvce$Technique == "Scroll",]$Time)
hist(srchscrlvce[srchscrlvce$Technique == "Voice",]$Time) # new one
plot(Time ~ Technique, data=srchscrlvce) # boxplot

# repeated measures ANOVA
library(ez)
# ez lets us specify the dependent variable (Time), within-Ss 
# variables (Technique), and the variable that identifies 
# subjects (Subject).
m = ezANOVA(dv=Time, within=Technique, wid=Subject, data=srchscrlvce)
# we then check the model for violations of sphericity. Sphericity is 
# the situation where the variances of the differences between all 
# combinations of levels of a within-Ss factor are equal. It always
# holds for within-Ss factors that have just 2 levels, but for 3+
# levels, sphericity can be tested with Mauchly's Test of Sphericity.
m$Mauchly # p<.05 indicates a violation
# if no violation, examine the uncorrected ANOVA in m$ANOVA. 
# if violation, instead look at m$Sphericity and use the 
# Greenhouse-Geisser correction, GGe.
m$ANOVA
# include the corrected DFs for each corrected effect
pos = match(m$`Sphericity Corrections`$Effect, m$ANOVA$Effect) # positions of within-Ss efx in m$ANOVA
m$Sphericity$GGe.DFn = m$Sphericity$GGe * m$ANOVA$DFn[pos] # Greenhouse-Geisser
m$Sphericity$GGe.DFd = m$Sphericity$GGe * m$ANOVA$DFd[pos]
m$Sphericity$HFe.DFn = m$Sphericity$HFe * m$ANOVA$DFn[pos] # Huynh-Feldt
m$Sphericity$HFe.DFd = m$Sphericity$HFe * m$ANOVA$DFd[pos]
m$Sphericity # show results

# the same uncorrected results are given by
m = aov(Time ~ Technique + Error(Subject/Technique), data=srchscrlvce) # fit model
summary(m) # show anova

# manual post hoc pairwise comparisons with paired-samples t-tests
library(reshape2)	
srchscrlvce.wide.tech = dcast(srchscrlvce, Subject ~ Technique, value.var="Time") # go wide
View(srchscrlvce.wide.tech)
se.sc = t.test(srchscrlvce.wide.tech$Search, srchscrlvce.wide.tech$Scroll, paired=TRUE)
se.vc = t.test(srchscrlvce.wide.tech$Search, srchscrlvce.wide.tech$Voice, paired=TRUE)
sc.vc = t.test(srchscrlvce.wide.tech$Scroll, srchscrlvce.wide.tech$Voice, paired=TRUE)
p.adjust(c(se.sc$p.value, se.vc$p.value, sc.vc$p.value), method="holm")


## Nonparametric equivalent of one-way repeated measures ANOVA

# first, examine Errors for 3 techniques
library(plyr)
ddply(srchscrlvce, ~ Technique, function(data) summary(data$Errors))
ddply(srchscrlvce, ~ Technique, summarise, Errors.mean=mean(Errors), Errors.sd=sd(Errors))
hist(srchscrlvce[srchscrlvce$Technique == "Search",]$Errors)
hist(srchscrlvce[srchscrlvce$Technique == "Scroll",]$Errors)
hist(srchscrlvce[srchscrlvce$Technique == "Voice",]$Errors) # new one
plot(Errors ~ Technique, data=srchscrlvce) # boxplot

# are the Voice error counts possibly Poisson distributed 
# as they seemed for Scroll and Search?
library(fitdistrplus)
fit = fitdist(srchscrlvce[srchscrlvce$Technique == "Voice",]$Errors, "pois", discrete=TRUE)
gofstat(fit) # goodness-of-fit test

# Friedman test on Errors
library(coin)
friedman_test(Errors ~ Technique | Subject, data=srchscrlvce, distribution="asymptotic")

# manual post hoc Wilcoxon signed-rank test multiple comparisons
se.sc = wilcox.test(srchscrlvce[srchscrlvce$Technique == "Search",]$Errors, srchscrlvce[srchscrlvce$Technique == "Scroll",]$Errors, paired=TRUE, exact=FALSE)
se.vc = wilcox.test(srchscrlvce[srchscrlvce$Technique == "Search",]$Errors, srchscrlvce[srchscrlvce$Technique == "Voice",]$Errors, paired=TRUE, exact=FALSE)
sc.vc = wilcox.test(srchscrlvce[srchscrlvce$Technique == "Scroll",]$Errors, srchscrlvce[srchscrlvce$Technique == "Voice",]$Errors, paired=TRUE, exact=FALSE)
p.adjust(c(se.sc$p.value, se.vc$p.value, sc.vc$p.value), method="holm")

# alternative approach is using PMCMR for nonparam pairwise comparisons
library(PMCMR)
posthoc.friedman.conover.test(srchscrlvce$Errors, srchscrlvce$Technique, srchscrlvce$Subject, p.adjust.method="holm") # Conover (1999)

# second, examine Effort Likert-scale ratings for all 3 techniques
library(plyr)
ddply(srchscrlvce, ~ Technique, function(data) summary(data$Effort))
ddply(srchscrlvce, ~ Technique, summarise, Effort.mean=mean(Effort), Effort.sd=sd(Effort))
hist(srchscrlvce[srchscrlvce$Technique == "Search",]$Effort, breaks=c(1:7), xlim=c(1,7))
hist(srchscrlvce[srchscrlvce$Technique == "Scroll",]$Effort, breaks=c(1:7), xlim=c(1,7))
hist(srchscrlvce[srchscrlvce$Technique == "Voice",]$Effort, breaks=c(1:7), xlim=c(1,7)) # new one
plot(Effort ~ Technique, data=srchscrlvce) # boxplot

# Friedman test on Effort
library(coin)
friedman_test(Effort ~ Technique | Subject, data=srchscrlvce, distribution="asymptotic")
# note! this omnibus test is not significant so post hoc comparisons are not justified.
# if we were to do them, we would use a set of 3 wilcoxon signed-rank tests corrected
# with Holm's sequential Bonferroni correction, just as we did for Errors, above.