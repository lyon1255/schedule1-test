using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppVLB_Samples
{
	// Token: 0x020000BC RID: 188
	public class FeaturesNotSupportedMessage : MonoBehaviour
	{
		// Token: 0x06000E08 RID: 3592 RVA: 0x0009DB20 File Offset: 0x0009BD20
		// Note: this type is marked as 'beforefieldinit'.
		static FeaturesNotSupportedMessage()
		{
			Il2CppClassPointerStore<FeaturesNotSupportedMessage>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "VLB_Samples", "FeaturesNotSupportedMessage");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FeaturesNotSupportedMessage>.NativeClassPtr);
			FeaturesNotSupportedMessage.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeaturesNotSupportedMessage>.NativeClassPtr, 100665025);
			FeaturesNotSupportedMessage.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeaturesNotSupportedMessage>.NativeClassPtr, 100665026);
		}

		// Token: 0x06000E09 RID: 3593 RVA: 0x0009DB78 File Offset: 0x0009BD78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85510, XrefRangeEnd = 85516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeaturesNotSupportedMessage.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E0A RID: 3594 RVA: 0x0009DBAC File Offset: 0x0009BDAC
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FeaturesNotSupportedMessage() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FeaturesNotSupportedMessage>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FeaturesNotSupportedMessage.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E0B RID: 3595 RVA: 0x00008C26 File Offset: 0x00006E26
		public FeaturesNotSupportedMessage(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04000978 RID: 2424
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000979 RID: 2425
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
