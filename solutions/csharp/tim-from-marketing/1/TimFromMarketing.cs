static class Badge
{
    public static string Print(int? id, string name, string? department) => (id != null ? String.Concat("[", String.Concat(id), "] - ") : "") + name + " - " + (department != null ? department.ToUpper() : "OWNER");
}