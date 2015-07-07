function solve() {
    'use strict';
    var module = (function() {

        // String
        function isString(value) {
            return (typeof value === 'string' || value instanceof String);
        }

        function checkStringAndThrow(value) {
            if (!isString(value)) {
                throw new Error(value + ' not a string!');
            }
        }

        // Number
        function isNumber(value) {
            return !isNaN(parseFloat(value)) && isFinite(value);
        }

        function checkNumberAndThrow(value) {
            if (!isNumber(value)) {
                throw new Error(value + ' not a number!');
            }
        }

        // others
        function getById(list, id) {
            var found = false,
                result;

            list.forEach(function(item) {
                if (item.id === id) {
                    result = item;
                    found = true;
                    return result;
                }
            });

            if (found === false) {
                return null;
            } else {
                return result;
            }
        }

        var playable = (function() {
            // Private functions
            var playableInternal = {},
                idPlayable = 0;

            Object.defineProperties(playableInternal, {
                'init': {
                    value: function(title, author) {
                        checkStringAndThrow(title);
                        checkStringAndThrow(author);

                        this.id = ++idPlayable;
                        this.title = title;
                        this.author = author;
                        return this;
                    }
                },
                'play': {
                    value: function() {
                        return this.id + '.' + this.title + ' - ' + this.author;
                    }
                }
            });
            return playableInternal;
        }());

        var audio = (function(parent) {
            var audioInternal = {};
            audioInternal = Object.create(parent);

            Object.defineProperties(audioInternal, {
                'init': {
                    value: function(title, author, length) {
                        checkNumberAndThrow(length);

                        if (length <= 0) {
                            throw new Error();
                        }

                        parent.init.call(this, title, author);
                        this.length = length;
                        return this;
                    }
                },
                'play': {
                    value: function() {
                        return parent.play.call(this) + ' - ' + this.length;
                    }
                }
            });

            return audioInternal;
        }(playable));

        var video = (function(parent) {
            var videoInternal = Object.create(parent);

            Object.defineProperties(videoInternal, {
                'init': {
                    value: function(title, author, imdbRating) {
                        checkNumberAndThrow(imdbRating);

                        if (imdbRating < 1 || imdbRating > 5) {
                            throw new Error();
                        }

                        parent.init.call(this, title, author);
                        this.imdbRating = imdbRating;
                        return this;
                    }
                },
                'play': {
                    value: function() {
                        return parent.play.call(this) + ' - ' + this.imdbRating;
                    }
                }
            });

            return videoInternal;
        }(playable));

        var playlist = (function() {
            var playlistInternal = {},
                idPlaylist = 0;

            Object.defineProperties(playlistInternal, {
                'init': {
                    value: function(name) {
                        checkStringAndThrow(name);

                        this.name = name;
                        this.id = ++idPlaylist;
                        this.playables = [];
                        return this;
                    }
                },
                'addPlayable': {
                    value: function(playableValue) {
                        var res;
                        //    if (playable.isPrototypeOf(playableValue)) {
                        res = getById(this.playables, playableValue.id);
                        if (res === null) {
                            this.playables.push(playableValue);
                        }
                        //    } else {
                        // throw new Error();
                        //    }
                        return this;
                    }
                },
                'getPlayableById': {
                    value: function(id) {
                        return getById(this.playables, id);
                    }
                },
                'removePlayable': {
                    value: function(id) {
                        if (isNumber(id) !== true) {
                            id = id.id;
                        }

                        if (getById(this.playables, id) === null) {
                            throw new Error();
                        }

                        this.playables = this.playables.filter(function(item) {
                            return id !== item.id;
                        });

                        return this;
                    }
                },
                'listPlaylables': {
                    value: function(page, size) {
                        var pl = this.playables.slice().sort(function(item1, item2) {
                                if (item1.name > item2.name) {
                                    return 1;
                                } else if (item1.name < item2.name) {
                                    return -1;
                                } else {
                                    return item2.id - item1.id;
                                }
                            }),
                            result = [],
                            i;

                        checkNumberAndThrow(page);
                        checkNumberAndThrow(size);

                        if (page * size < pl.length || page < 0 || size <= 0) {
                            throw new Error();
                        }

                        for (i = page * size; i < Math.min((page * size) + size - 1, pl.length); i += 1) {
                            result.push(pl[i]);
                        }

                        return result;
                    }
                }
            });

            return playlistInternal;
        }());

        var player = (function() {
            var playerInternal = {},
                idPlayer;

            Object.defineProperties(playerInternal, {
                'getPlayer': {
                    value: function(name) {
                        checkStringAndThrow(name);

                        this.name = name;
                        this.id = ++idPlayer;
                        this.playlists = [];
                        return this;
                    }
                },
                'addPlaylist': {
                    value: function(playlistToAdd) {
                        var res;
                        //    if (playlist.isPrototypeOf(playlistToAdd)) {
                        res = getById(this.playlists, playlistToAdd.id);
                        if (res === null) {
                            this.playlists.push(playlistToAdd);
                        }
                        //    } else {
                        // throw new Error();
                        //    }
                        return this;
                    }
                },
                'getPlaylistById': {
                    value: function(id) {
                        return getById(this.playlists, id);
                    }
                },
                'removePlaylist': {
                    value: function(id) {
                        if (isNumber(id) !== true) {
                            id = id.id;
                        }

                        if (getById(this.playlists, id) === null) {
                            throw new Error();
                        }

                        this.playables = this.playlists.filter(function(item) {
                            return id !== item.id;
                        });

                        return this;
                    }
                },
                'listPlaylists': {
                    value: function(page, size) {
                        var pl = this.playlists.slice().sort(function(item1, item2) {
                                if (item1.name > item2.name) {
                                    return 1;
                                } else if (item1.name < item2.name) {
                                    return -1;
                                } else {
                                    return item2.id - item1.id;
                                }
                            }),
                            result = [],
                            i;

                        checkNumberAndThrow(page);
                        checkNumberAndThrow(size);

                        if (page * size < pl.length || page < 0 || size <= 0) {
                            throw new Error();
                        }

                        for (i = page * size; i < Math.min((page * size) + size - 1, pl.length); i += 1) {
                            result.push(pl[i]);
                        }

                        return result;
                    }
                }
            });
            return playerInternal;
        }());

        return {
            getPlayer: function(name) {
                return Object.create(player).getPlayer(name);
            },
            getPlaylist: function(name) {
                return Object.create(playlist).init(name);
            },
            getAudio: function(title, author, length) {
                return Object.create(audio).init(title, author, length);
            },
            getVideo: function(title, author, imdbRating) {
                return Object.create(video).init(title, author, imdbRating);
            }
        };

    })();

    return module;
}

module.exports = solve;
