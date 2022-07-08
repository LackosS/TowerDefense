using System;
using System.Threading.Tasks;

namespace TowerDefensePersistence
{
    /// <summary>
    /// Fájlkezelő interfésze
    /// </summary>
    public interface IPersistence
    {
        Task<GameData> LoadAsync(String path);
        Task SaveAsync(String path, GameData gamedata);
    }
}
