|Regular Expression | Result (XPath)|
| ------------- |:-------------:|
| [A-z0-9._%+-]+@[A-z0-9.-]+.[A-z]{2,4} | 1. id('content')/div[3], 2. id('content')/div[5]/div[1]/a
| \([0-9]{2}\)\s+[0-9]{3}\s+[0-9]{4} | 1. id('content')/div[3], 2. id('content')/div[5]/div[2]
| \d{4}\s\d{3}\s\d{2} | id('content')/div[1]/div[2]/div[2]/strong
| \d{2}-\d{2}-\d{4} | id('content')/div[5]/div[2]
| \w+\,+\s+\d{1,2}\s+\w+\s+\d{4}\,+\s+\d{2}:\d{2}:\d{2} | id('content')/div[1]/div[1]/p
