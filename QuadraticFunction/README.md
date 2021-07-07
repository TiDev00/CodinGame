Pour une fonction polynome du second degrée donnée sous la forme f(x)=ax²+bx+c, on souhaite calculer le résultat de cette fonction pour une valeur de x.
Par exemple, pour la fonction simple(x)=x²+x+1, et x=4, le résultat attendu est 21. 

Note : certains coefficients peuvent être manquant, comme dans cet exemple : linear(x)=-3x+2 
Implémentez la méthode int ApplyFunction(string quadraticFunction, int x) qui prend une fonction polynome et une valeur x en paramètres et retourne la valeur de 
cette fonction pour cette valeur x.

Constraintes:
-1000 < a,b,c,x < 1000 Les produits du polynome sont toujours donnés dans le même ordre : les plus grands exposants d'abord. Par exemple k(x)=-2+3x-4x² n'est pas 
un paramètre valide
