using POONETVeterinaire.Models;



Chat chat = new Chat("Chanel", 12, "Blond venicien");

Chien chien = new Chien("Rantanplan", 2, "Levrier");

Clinique clinique = new Clinique(chat, chien);

clinique.Afficher();

clinique.Supprimer(chat);

clinique.Afficher();