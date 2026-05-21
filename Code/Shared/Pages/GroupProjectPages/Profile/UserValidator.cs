using System;
using System.Linq;

namespace Abc.Shared.Pages.GroupProjectPages.Profile
{
    public static class UserValidator
    {
        public static bool TryValidate(string? name, string? email, out string? errorMessage)
        {
            errorMessage = null;
            string username = name?.Trim() ?? "";

            if (username is "") return Error("Kasutajanimi ei tohi olla tühi!", out errorMessage);
            if (username is { Length: > 15 }) return Error("Kasutajanimi võib olla maksimaalselt 15 tähemärki pikk!", out errorMessage);
            if (username.Any(char.IsDigit)) return Error("Kasutajanimi ei tohi sisaldada numbreid!", out errorMessage);

            string mail = email?.Trim() ?? "";
            if (!mail.EndsWith("@gmail.com", StringComparison.OrdinalIgnoreCase)) return Error("E-post peab lõppema domeeniga @gmail.com!", out errorMessage);
            if (mail.Count(x => x == '@') != 1) return Error("E-post peab sisaldama täpselt ühte @ märki!", out errorMessage);

            int prefixLength = mail.Length - 10;
            if (prefixLength == 0) return Error("E-posti aadressil peab enne @ märki olema kasutajatunnus!", out errorMessage);
            if (prefixLength > 15) return Error("E-posti eesliide (enne @ märki) võib olla maksimaalselt 15 tähemärki pikk!", out errorMessage);

            return true;
        }

        private static bool Error(string message, out string? targetMessage)
        {
            targetMessage = message;
            return false;
        }
    }
}