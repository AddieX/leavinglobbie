public void Quit()
{
    manager.offlineScene = "";
    SceneManager.LoadScene("Menu");
    SteamLobby.Instance.LeaveLobby();

    if (hasAuthority)
    {
        if (isServer)
        {
            manager.StopHost();
        }
        else
        {
            manager.StopClient();
        }
    }
}