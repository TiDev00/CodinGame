Afin de détecter des erreurs dans des identifiants numériques, une clé de contrôle est souvent ajoutée à 
cet identifiant.
Implémentez la méthode ComputeCheckDigit(identificationNumber) qui prend en entrée un identifiant 
(sous la forme d'une chaîne de caractères) et qui retourne la clé de contrôle en utilisant l'algorithme qui 
suit :
Faites la somme des chiffres situés à des positions paires (positions 0, 2, 4, etc.). Multipliez le résultat par 
trois. Ajoutez à ce nombre la somme des chiffres situés à des positions impaires (positions 1, 3, 5, etc.). 
Prenez le dernier chiffre de ce résultat. Si ce nombre n'est pas 0, soustrayez le à 10. Sinon, gardez 0. 
Retournez le chiffre résultant (On suppose que le premier chiffre situé à gauche a pour position 0)

Exemple:
Soit l'identifiant 39847 :
Sommez les chiffres aux positions paires : 3 + 8 + 7 = 18 Multipliez par trois : 18 x 3 = 54 Ajoutez les 
chiffres situées aux positions impaires : 54 + (9 + 4) = 67 Le dernier chiffre est 7 Soustrayez 7 à 10 : 10 - 7 = 3
Le résultat attendu pour 39847 est 3.

Contraintes:
La longueur de identificationNumber peut varier de 1 à 12 caractères.
