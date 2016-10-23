using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 兔子AES算法
{
    class Program
    {

        static void Main(string[] args)
        {

        }
        // AES加密
	public String encrypt_AES(String source, String key)  {

		if (key == null) {
			return null;
		}
		// 判断key是否为16位
		if (key.Length!= 16) {
			return null;
		}
		byte[] raw = key.getBytes();
		SecretKey keySpec = new SecretKeySpec(raw, "AES");
		// 算法/模式/补码方式
		Cipher cipher = Cipher.getInstance("AES/CBC/PKCS5Padding");
		// 使用CBC模式，需要一个向量，可增加算法的强度
		IvParameterSpec iv = new IvParameterSpec("0102030405060708".getBytes());
		cipher.init(Cipher.ENCRYPT_MODE, keySpec, iv);
		byte[] encrypted = cipher.doFinal(source.getBytes());
		return Base64.encodeToString(encrypted, Base64.DEFAULT);

	}

	// AES解密
	public String decrypt_AES(String resource, String key) throws Exception {

		try {
			// 判断key是否正确
			if (key == null) {

				return null;

			}

			if (key.length() != 16) {
				return null;
			}

			byte[] raw = key.getBytes("ASCII");
			SecretKey keySpec = new SecretKeySpec(raw, "AES");
			// 算法/模式/补码方式
			Cipher cipher = Cipher.getInstance("AES/CBC/PKCS5Padding");
			// 使用CBC模式，需要一个向量，可增加算法的强度
			IvParameterSpec iv = new IvParameterSpec(
					"0102030405060708".getBytes());
			cipher.init(Cipher.ENCRYPT_MODE, keySpec, iv);
			byte[] encrypted1 = Base64.decode(resource, Base64.DEFAULT);
			try {

				byte[] original = cipher.doFinal(encrypted1);
				String originalString = new String(original);
				return originalString;
			} catch (Exception e) {
				return null;
			}

		} catch (Exception e) {
			return null;

		}

	}
    }
}
