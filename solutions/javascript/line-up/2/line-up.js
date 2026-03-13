export const format = (name, number) => {
  let suffix = 'th';
  if (number % 10 == 1 && !number.toString().endsWith('11')) {
    suffix = 'st';
  } else if (number % 10 == 2 && !number.toString().endsWith('12')) {
    suffix = 'nd';
  } else if (number % 10 == 3 && !number.toString().endsWith('13')) {
    suffix = 'rd';
  }
  return `${name}, you are the ${number}${suffix} customer we serve today. Thank you!`;
};