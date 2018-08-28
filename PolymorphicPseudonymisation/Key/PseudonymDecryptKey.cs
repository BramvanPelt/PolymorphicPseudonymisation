﻿using PolymorphicPseudonymisation.Parser;

namespace PolymorphicPseudonymisation.Key
{
    public class PseudonymDecryptKey : DecryptKey
    {

        protected internal PseudonymDecryptKey(DecryptKeyParser parser) : base(parser)
        {
        }

        /// <summary>
        /// Convert decrypt key to encrypted verifiers for the pseudonym only </summary>
        /// <param name="verificationPoint"> Base64 verification point for pseudonym </param>
        public virtual EncryptedVerifiers ToVerifiers(string verificationPoint)
        {
            return new EncryptedVerifiers(null, GetVerifier(verificationPoint));
        }
    }
}