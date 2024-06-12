export const SUITS = ['Hearts', 'Diamonds', 'Clubs', 'Spades'];
export const VALUES = [
  '2',
  '3',
  '4',
  '5',
  '6',
  '7',
  '8',
  '9',
  '10',
  'Jack',
  'Queen',
  'King',
  'Ace',
]

export const getCardNumericValue = (value: string): number => {
  switch (value) {
    case 'Ace':
      return 1;
    case '2':
      return 2;
    case '3':
      return 3;
    case '4':
      return 4;
    case '5':
      return 5;
    case '6':
      return 6;
    case '7':
      return 7;
    case '8':
      return 8;
    case '9':
      return 9;
    case '10':
    case 'Jack':
    case 'Queen':
    case 'King':
      return 10;
    default:
      return 0;
  }
}