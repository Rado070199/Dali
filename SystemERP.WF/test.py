import GeneticAlgorihms as ga

test = ga.AlgorithmForSingleMachineScheduling(30, 0.8, 0.1, 0.5, 2000)

for element in test:
    print(element)
    
ga.DiagramForSingleMachineScheduling(test[0])

test2 = ga.AlgorithmGeneticFlowShopScheduler(30, 0.8, 0.2, 0.2, 2000)

for element in test2:
    print(element)
    
ga.DiagramGeneticFlowShopScheduler(test2[0])