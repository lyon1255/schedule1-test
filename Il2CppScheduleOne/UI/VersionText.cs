using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000673 RID: 1651
	public class VersionText : MonoBehaviour
	{
		// Token: 0x06009363 RID: 37731 RVA: 0x0025EFCC File Offset: 0x0025D1CC
		// Note: this type is marked as 'beforefieldinit'.
		static VersionText()
		{
			Il2CppClassPointerStore<VersionText>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "VersionText");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VersionText>.NativeClassPtr);
			VersionText.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionText>.NativeClassPtr, 100681572);
			VersionText.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionText>.NativeClassPtr, 100681573);
		}

		// Token: 0x06009364 RID: 37732 RVA: 0x0025F024 File Offset: 0x0025D224
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 265271, XrefRangeEnd = 265282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VersionText.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009365 RID: 37733 RVA: 0x0025F058 File Offset: 0x0025D258
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VersionText() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VersionText>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VersionText.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009366 RID: 37734 RVA: 0x000476B4 File Offset: 0x000458B4
		public VersionText(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x0400637F RID: 25471
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04006380 RID: 25472
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
