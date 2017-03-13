(function(){
  var styles = document.createElement('style');
  styles.innerText = '.video-player { width: 100%; position: relative; padding: 2px 0 56.25% 0; height: 0; } .video-player iframe { position: absolute; top: 0; left: 0; width: 100%; height: 100%; }';
  document.body.prepend(styles);
  var videoText = document.querySelector('.video-player').textContent;
  var regex = /watch\?v=([a-zA-Z0-9_-]+)?/g;
  var matches = regex.exec(videoText) || [''];
  var videoId = matches[1];
  var iframe = "<iframe src='https://www.youtube.com/embed/" + 
    videoId + "' frameborder='0' allowfullscreen>";
  document.querySelector('.video-player').innerHTML = iframe;
})();
