START TRANSACTION;

UPDATE cv SET identifier = 'https://creativecommons.org/publicdomain/zero/1.0/' WHERE slug = 'cc0';
UPDATE cv SET identifier = 'https://creativecommons.org/licenses/by/4.0/' WHERE slug = 'cc-by-40';
UPDATE cv SET identifier = 'https://creativecommons.org/licenses/by-nc/4.0/' WHERE slug = 'cc-by-nc-40';
UPDATE cv SET identifier = 'https://creativecommons.org/licenses/by-nc-nd/4.0/' WHERE slug = 'cc-by-nc-nd-40';
UPDATE cv SET identifier = 'https://creativecommons.org/licenses/by-nc-sa/4.0/' WHERE slug = 'cc-by-nc-sa-40';
UPDATE cv SET identifier = 'https://creativecommons.org/licenses/by-nd/4.0/' WHERE slug = 'cc-by-nd-40';
UPDATE cv SET identifier = 'https://creativecommons.org/licenses/by-sa/4.0/' WHERE slug = 'cc-by-sa-40';
UPDATE cv SET identifier = 'https://opendatacommons.org/licenses/odbl/1-0/' WHERE slug = 'odbl-10';
UPDATE cv SET identifier = 'https://opendatacommons.org/licenses/pddl/1-0/' WHERE slug = 'pddl-10';
UPDATE cv SET identifier = 'https://opendatacommons.org/licenses/by/1-0/' WHERE slug = 'odc-by-10';

COMMIT;
