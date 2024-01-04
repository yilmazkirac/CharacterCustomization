using UnityEngine;

public class Character : MonoBehaviour
{

    public GameObject[] _head;
    public GameObject[] _body;
    public GameObject[] _foot;
    public Material _color;

    public bool IsCreate;

    public void CreatCharacter()
    {
        ChangeHead(0);
        ChangeBody(0);
        ChangeFoot(0);
        IsCreate=true;
    }
    private void CloseHead()
    {
        foreach (var item in _head)
        {
            item.SetActive(false);
        }
    }
    private void CloseBody()
    {
        foreach (var item in _body)
        {
            item.SetActive(false);
        }
    }
    private void CloseFoot()
    {
        foreach (var item in _foot)
        {
            item.SetActive(false);
        }
    }
    public void ChangeHead(int index)
    {
        CloseHead();
        _head[index].SetActive(true);
    }
    public void ChangeBody(int index)
    {

        CloseBody();
        _body[index].SetActive(true);

    }
    public void ChangeFoot(int index)
    {

        CloseFoot();
        _foot[index].SetActive(true);
    } 
}
