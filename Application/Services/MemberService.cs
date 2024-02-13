using System; // Importe les fonctionnalités de base de .NET
using System.Collections.Generic; // Importe les collections génériques
using System.Linq; // Importe les fonctionnalités de LINQ (Language Integrated Query)
using System.Text; // Importe les fonctionnalités de manipulation de chaînes de caractères
using System.Threading.Tasks; // Importe les fonctionnalités liées à la programmation asynchrone
using Application.Interfaces; // Importe l'interface IMemberRepository
using Domain.Entities; // Importe l'entité Member du domaine

namespace Application.Services // Définit un espace de noms pour les services de l'application
{
    // Implémente les règles métier / cas d'utilisation
    public class MemberService : IMemberService // Définit une classe MemberService qui implémente IMemberService
    {
        private readonly IMemberRepository memberRepository; // Déclare un champ pour stocker une référence à IMemberRepository

        public MemberService(IMemberRepository memberRepository)
        {
            this.memberRepository = memberRepository; // Initialise le champ memberRepository avec une instance fournie lors de la création de MemberService
        }

        // Implémente la méthode GetAllMembers de l'interface IMemberService
        List<Member> IMemberService.GetAllMembers()
        {
            return memberRepository.GetAllMembers(); // Utilise le repository pour récupérer la liste de tous les membres et la renvoie
        }
    }
}
