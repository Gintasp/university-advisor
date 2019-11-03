import React from 'react';
import { TYPE_UNIVERSITY } from '../config/types';

class InputDropdown extends React.PureComponent {
  componentDidMount() {
    window.addEventListener('keyup', e => this.handleClose(e));
  }

  componentWillUnmount() {
    window.removeEventListener('keyup', e => this.handleClose(e));
  }

  handleClose(e) {
    const { onClose } = this.props;
    if (e.which === 27) {
      onClose();
    }
  }

  render() {
    const { items, onItemClick, opened } = this.props;

    if (!opened) {
      return null;
    }

    return (
      <div className="input-dropdown">
        <ul className="list-none p-0 m-0">
          {items.map((item, index) => (
            <li
              className="search-item"
              key={index}
              onClick={() => onItemClick(item)}
            >
              {item.Title}
              {item.Type !== TYPE_UNIVERSITY && (
                <p className="list-subitem">{item.University}</p>
              )}
            </li>
          ))}
        </ul>
      </div>
    );
  }
}

export default InputDropdown;
