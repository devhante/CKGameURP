using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class ClickHandler : MonoBehaviour
{
	[SerializeField] private UnityEvent _clicked;

	private Collider2D _collider;
	private MouseInputProvider _mouse;
	private SpriteRenderer _sr;

	private void Awake()
	{
		_collider = GetComponent<Collider2D>();
		_mouse = FindObjectOfType<MouseInputProvider>();
		_mouse.Clicked += MouseOnClicked;
		_sr = GetComponent<SpriteRenderer>();
	}   

	private void MouseOnClicked()
	{
		if (!EventSystem.current.IsPointerOverGameObject())
		{
			if (_collider.bounds.Contains(_mouse.WorldPosition))
			{
				FindObjectOfType<ClickManager>().eventList.Add(_clicked);
				FindObjectOfType<ClickManager>().orderList.Add(_sr.sortingOrder);
				// _clicked?.Invoke();
			}
		}
	}
}