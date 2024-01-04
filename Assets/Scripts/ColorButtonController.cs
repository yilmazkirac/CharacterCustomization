using UnityEngine;
public enum ObjectType { COLOR, HEAD, BODY, FOOT }
public class ColorButtonController : MonoBehaviour
{
    public int Index;
    public ObjectType Type;
    [SerializeField] private Character _character;


    public int headIndex;
    public int bodyIndex;
    public int footIndex;
    public int colortIndex;
    public void Next()
    {
        if (_character.IsCreate)
        {
            Index += 1;
            SetIndex(Type);
        }
    }
    public void Back()
    {
        if (_character.IsCreate)
        {
            Index -= 1;
            SetIndex(Type);
        }        
    }
    public void SetIndex(ObjectType type)
    {
        switch (type)
        {
            case ObjectType.HEAD:
                
                if (Index >= _character._head.Length - 1)
                {
                    Index = _character._head.Length - 1;
                    headIndex = Index;
                }
                else if (Index <= 0)
                {
                    Index = 0;
                    headIndex = Index;
                }
                else
                {
                    headIndex = Index;
                }
                _character.ChangeHead(headIndex);
                break;
            case ObjectType.BODY:
                if (Index >= _character._body.Length - 1)
                {
                    Index = _character._body.Length - 1;
                    bodyIndex = Index;
                }
                else if (Index <= 0)
                {
                    Index = 0;
                    bodyIndex = Index;
                }
                else
                {
                    bodyIndex = Index;
                }
                _character.ChangeBody(bodyIndex);
                break;
            case ObjectType.FOOT:
                if (Index >= _character._foot.Length - 1)
                {
                    Index = _character._foot.Length - 1;
                    footIndex = Index;
                }
                else if (Index <= 0)
                {
                    Index = 0;
                    footIndex = Index;
                }
                else
                {
                    footIndex = Index;
                }
                _character.ChangeFoot(footIndex);
                break;
            case ObjectType.COLOR:
                if (Index >= 2)
                {
                    Index = 2;
                    colortIndex = Index;
                }
                else if (Index <= 0)
                {
                    Index = 0;
                    colortIndex = Index;
                }
                else
                {
                    colortIndex = Index;
                }
                if (Index==0)
                {
                    _character._color.color = Color.green;
                }
                else if (Index==1)
                {
                    _character._color.color = Color.blue;
                }
                else
                {
                    _character._color.color = Color.red;
                }
                 break;
        }
    }
}
