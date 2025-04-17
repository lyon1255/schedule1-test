using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Noise
{
	// Token: 0x0200036C RID: 876
	public static class NoiseUtility : Il2CppSystem.Object
	{
		// Token: 0x0600446E RID: 17518 RVA: 0x0002169A File Offset: 0x0001F89A
		// Note: this type is marked as 'beforefieldinit'.
		static NoiseUtility()
		{
			Il2CppClassPointerStore<NoiseUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Noise", "NoiseUtility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NoiseUtility>.NativeClassPtr);
			NoiseUtility.NativeMethodInfoPtr_EmitNoise_Public_Static_Void_Vector3_ENoiseType_Single_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoiseUtility>.NativeClassPtr, 100671655);
		}

		// Token: 0x0600446F RID: 17519 RVA: 0x0015240C File Offset: 0x0015060C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 154911, RefRangeEnd = 154914, XrefRangeStart = 154879, XrefRangeEnd = 154911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void EmitNoise(Vector3 origin, ENoiseType type, float range, GameObject source = null)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref origin;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref range;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(source);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoiseUtility.NativeMethodInfoPtr_EmitNoise_Public_Static_Void_Vector3_ENoiseType_Single_GameObject_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004470 RID: 17520 RVA: 0x000216D3 File Offset: 0x0001F8D3
		public NoiseUtility(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04002DD5 RID: 11733
		private static readonly IntPtr NativeMethodInfoPtr_EmitNoise_Public_Static_Void_Vector3_ENoiseType_Single_GameObject_0;
	}
}
