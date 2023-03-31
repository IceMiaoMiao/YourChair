Continue = {}
local this = Continue
function this.ReStart(obj)
    local reStartBtn = obj.transform : Find("ReStart").gameObject
    UIEvent.AddButtonOnClick(reStartBtn, ReStartOnClick)
end

function this.Quit(obj)
    local quitBtn = obj.transform : Find("Quit").gameObject
    UIEvent.AddButtonOnClick(quitBtn,QuitGame)
end

function ReStartOnClick ()
    SceneManagement.SceneManager.LoadScene("Jump")
end

function QuitGame()
    print("Quit Game")
    UnityEngine.Application.Quit()
end
