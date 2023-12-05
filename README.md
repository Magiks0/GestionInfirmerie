# Système de Gestion de l'Infirmerie

## Présentation

Ce projet en C# répond aux besoins d'un lycée privé souhaitant rationaliser la gestion des dossiers de santé des élèves au sein de son infirmerie. L'application couvre la gestion complète des élèves, des visites à l'infirmerie et des médicaments. Développée par notre équipe de développeurs dévoués, cette application garantit la confidentialité des informations de santé grâce à une authentification sécurisée.

## Fonctionnalités

### Gestion des Élèves
- Consulter, ajouter et modifier les détails des élèves via une fenêtre dédiée.
- Supprimer des élèves uniquement s'ils n'ont pas effectué de visite à l'infirmerie.
- Les détails des élèves comprennent le nom, la date de naissance, le numéro de téléphone portable, la classe, le numéro de téléphone des parents, les aménagements d'examens (temps supplémentaire) et un commentaire de santé libre.

### Gestion des Visites à l'Infirmerie
- Consulter, ajouter et modifier les visites à l'infirmerie via une fenêtre détaillée.
- Filtrer les visites par mois, date et/ou nom de l'élève.
- Chaque visite est liée à un élève, a une date, une heure de début et de fin, un motif de visite et des commentaires supplémentaires.
- Capturer des informations sur le retour de l'élève à la maison ou son transfert à l'hôpital après la visite, et si les parents ont été informés.

### Gestion des Médicaments
- Consulter, ajouter et modifier les détails des médicaments via une fenêtre dédiée.
- Supprimer des médicaments uniquement s'ils ne sont pas associés à une visite.
- Chaque médicament peut être lié ou non à une visite, avec des quantités spécifiées.

### Module de Statistiques
- Un écran informatif résume les données clés de l'application.
- Comprend le nombre total d'élèves, le nombre total de visites, la moyenne de visites par élève, la durée moyenne d'une visite, le nombre total de médicaments administrés au cours de l'année scolaire, et la moyenne de médicaments par visite.
- Les utilisateurs peuvent filtrer les statistiques pour une plage de dates spécifique.

## Mise en Route

Pour déployer et utiliser l'application, veuillez suivre les instructions du guide utilisateur fourni. Le guide couvre l'installation, l'authentification et une présentation détaillée de chaque module.

Nous espérons que ce Système de Gestion de l'Infirmerie améliorera l'efficacité de la gestion des dossiers de santé dans votre établissement. Si vous rencontrez des problèmes ou avez des suggestions d'amélioration, n'hésitez pas à nous en informer via le suivi des problèmes.
