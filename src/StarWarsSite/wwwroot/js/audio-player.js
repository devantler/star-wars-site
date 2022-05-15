window.PlayAudio = (elementName) => {
    var audioElement = document.getElementById(elementName);
    audioElement.volume = 0.05;
    audioElement.play();
}