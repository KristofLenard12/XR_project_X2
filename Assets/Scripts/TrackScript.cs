using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TrackScript : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> tracks;

    [SerializeField]
    private TextMeshPro _lapTimes;

    private List<string> _laps;
    private bool _start;
    private float _lapTime;
    private string _currentTrack;
    private int _run;


    // Start is called before the first frame update
    void Start()
    {
        _currentTrack = "8";
        foreach (GameObject track in tracks)
        {
            track.SetActive(false);
        }
        tracks[3].SetActive(true);

        _laps = new List<string>();
        _run = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (_start)
        {
            _lapTime += Time.deltaTime;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (_start)
        {
            _start = false;
            if(_lapTime > 12)
            {
                string lap = _lapTime + "";
                lap = lap.Substring(0, 6);
                _laps.Add("Track: " + _currentTrack + "\n" + "==========================" + "\n" + "Time: " + lap + "\n" + "Run: " + _run + "\n" );
                if(_laps.Count > 6)
                {
                    int index = 0;
                    float current = 0f;
                    float temp = 0f;
                    for (int i = 0; i < _laps.Count; i++)
                    {
                        temp = float.Parse(_laps[i]);
                        if (temp > current)
                        {
                            current = temp;
                            index = i;
                        }
                    }
                    _laps.RemoveAt(index);
                }
                _run++;
                _lapTimes.text = "";
                foreach (string laps in _laps)
                {
                    _lapTimes.text += laps;
                }
            }
        }
        else
        {
            _start = true;
            _lapTime = 0f;
        }
    }

    public void SetTrack(int trackNumber)
    {
        if(trackNumber < 0)
        {
            foreach (GameObject track in tracks)
            {
                track.SetActive(false);
            }
        }
        else
        {
            tracks[int.Parse(_currentTrack) - 1].SetActive(false);
            for (int i = 0; i < tracks.Count; i++)
            {
                if(i == trackNumber)
                {
                    tracks[i].SetActive(true);
                    _currentTrack = "" + (trackNumber + 1);
                    break;
                }else{
                    tracks[i].SetActive(false);
                }
            }
        }
    }
}
