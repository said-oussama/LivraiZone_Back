using System;
using System.Collections.Generic; 
using System.Linq; 
using System.Text; 
using System.Threading.Tasks; 
using Application.Interfaces; 
using Domain.Entities; 

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
