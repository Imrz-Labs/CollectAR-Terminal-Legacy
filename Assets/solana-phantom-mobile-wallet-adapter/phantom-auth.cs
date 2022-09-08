using UnityEngine;
using System.Collections;

public class MYCLASSNAME : MonoBehaviour {
import {PublicKey, Transaction} from '@solana/web3.js';

export interface CommonWallet {
  name: string;
  url: string;
  icon: string;
  readyState: string;
  publicKey: PublicKey;
  connecting: boolean;
  connected: boolean;

  wallets: string[];
  autoConnect: boolean;
  disconnecting: boolean;
  wallet: {
    name: string;
    url: string;
    icon: string;
  };

  connect?: () => Promise<void>;
  disconnect: () => void;
  signTransaction: ( Transaction transaction  ) => Promise<Transaction | Buffer>;
  signMessage: ( Uint8Array message  ) => Promise<Uint8Array>;
}
}