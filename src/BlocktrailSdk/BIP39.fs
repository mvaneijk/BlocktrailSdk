﻿module BIP39

/// generate random entropy using \MCRYPT_DEV_URANDOM
///
/// @param int  $size                    desired strength, must be multiple of 32, recommended 128-256
/// @throws \Exception
/// @return string                       hex Entropy
let generateEntropy size = 
    (*
    {
        if ($size % 32 !== 0) {
            throw new \Exception("Entropy must be in a multiple of 32");
        }

        return bin2hex(mcrypt_create_iv($size / 8, \MCRYPT_DEV_URANDOM));
    }
    *)
    ""

/// Create Mnemonic from Entropy
///
/// @param string        $entropyHex     hex Entropy
/// @param BIP39WordList $wordList       defaults to BIP39 english word list
/// @return string                       hex Mnemonic
/// @throws \Exception
////
let entropyToMnemonic entropyHex (wordList : string list option) = 
    (*
    // calculate entropy, /2 because PHP can't do bytes
    $ENT = (strlen($entropyHex) / 2) * 8;
    // calculate how long the checksum should be
    $CS = $ENT / 32;

    // get the checksum
    $checksum = self::entropyChecksum($entropyHex);

    // create the string of bits to use
    $bits = str_pad(gmp_strval(gmp_init($entropyHex, 16), 2) . $checksum, $ENT + $CS, "0", STR_PAD_LEFT); // PHP trims off 0s

    // use provided wordList or default
    $wordList = $wordList ?: self::defaultWordList();

    // build word list
    $result = array();
    foreach (str_split($bits, 11) as $bit) {
        $idx = gmp_strval(gmp_init($bit, 2), 10);

        $result[] = $wordList->getWord($idx);
    }

    // implode and enjoy
    $result = implode(" ", $result);

    return $result; 
    *)
    ""