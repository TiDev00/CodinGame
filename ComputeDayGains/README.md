Pour attirer les touristes, un Casino de Las Vegas propose un buffet à volonté où chacun paye ce qu'il souhaite payer.
Sachant que vous connaissez ce que chaque touriste est prêt à payer, on vous demande de calculer les 
gains du restaurant pour la journée :
En début de journée le restaurant est vide. Un touriste arrive, est placé, mange, paye et s'en va. Il y a 
seulement nbSeats places disponibles. Un touriste peut manger et payer seulement s'il peut être placé. 
Si un touriste arrive au restaurant alors qu'il n'y a plus de places disponibles : soit il attend son tour 
jusqu'à ce qu'une place se libère soit il attend un moment et part avant qu'une place se libère Un 
touriste peut venir plusieurs fois dans la journée, dans ce cas il ne paye au maximum qu'une seule fois.
Implémentez la méthode ComputeDayGains(nbSeats, payingGuests, guestMovements) qui renvoie les 
gains de la journée :
Le tableau payingGuests contient ce que chaque touriste est prêt à payer. Par exemple si payingGuests[5]
vaut 25, cela veut dire que le touriste avec l'idenfiant 5 est prêt à payer 25$ pour le buffet. Le tableau 
guestMovements donne l'ordre des arrivées et départs des touristes. La première fois que vous trouvez 
un identifiant dans le tableau, il s'agit d'une arrivée. La deuxième fois, il s'agit d'un départ. Un arrivée est 
toujours suivie d'un départ dans la journée.
