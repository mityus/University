using System;
using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;
using UnityEngine.UI;
using Image = UnityEngine.UI.Image;
using UnityEngine.SceneManagement;

namespace Common
{
    public class ButtonControler : MonoBehaviour
    {
        [SerializeField] private Sprite newSprite;

        [Space] [SerializeField] private Image imageOwl;

        [Space] [SerializeField] private string nameScene;

        private Image _image;

        private void Start()
        {
            _image = imageOwl.GetComponent<Image>();
        }

        public void ChangeSprite()
        {
            _image.sprite = newSprite;
        }

        public void StartScene()
        {
            SceneManager.LoadScene(nameScene);
        }

        public void QuitApplication()
        {
            Application.Quit();
        }
        
        
    }
}
