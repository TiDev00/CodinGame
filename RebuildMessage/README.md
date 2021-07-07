On vous demande de reconstituer un message qui a été coupé en morceaux. Implémentez la méthode RebuildMessage(parts) qui reçoit en paramètre un tableau 
de chaînes de caractères. Chaque élément de parts a été découpé à partir d'un seul et même message. Vous devez reconstituer le message original, à partir des règles suivantes :
le message original commence toujours par le caractère A et finit par le caractère Z deux parties peuvent être rattachées lorsque le dernier caractère de la première 
partie est égal au premier caractère de la deuxième partie. Lors de la combinaison de deux parties, on ne conserve qu'un exemplaire du caractère 
de liaison (par exemple "A---b"  + "b---Z" donne "A---b---Z et non "A---bb---Z")
RebuildMessage doit retourner le message reconstitué.

Contraintes :
chaque premier caractère est unique parmi parts chaque partie contient au moins 2 caractères et au plus 1000 caractères la solution existe forcément et est unique parts 
n'est jamais null, contient au moins un élément et au plus 100 éléments

EXEMPLES:
Parties
Ab
bcZ
Message
AbcZ
Parties
*====# 
X-+-+-+-+-+-Z 
#______X 
A.........*
Message
A.........*====#______X-+-+-+-+-+-Z
