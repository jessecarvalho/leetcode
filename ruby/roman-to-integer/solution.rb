class Solution

    def translate(letter)
      case letter
      when 'I'
        1
      when 'V'
        5
      when 'X'
        10
      when 'L'
        50
      when 'C'
        100
      when 'D'
        500
      when 'M'
        1000
      else
        0
      end
    end
  
    def roman_to_int(s)
      sum = 0
      s.each_char.with_index do |_, i|
        current = translate(s[i])
        next_val = i + 1 < s.length ? translate(s[i + 1]) : 0
        if current < next_val
          sum -= current
        else
          sum += current
        end
      end
      sum
    end
  end
  