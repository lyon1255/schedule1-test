using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Building
{
	// Token: 0x020004C2 RID: 1218
	public class OverrideGhostMaterial : MonoBehaviour
	{
		// Token: 0x06006AB6 RID: 27318 RVA: 0x00032728 File Offset: 0x00030928
		// Note: this type is marked as 'beforefieldinit'.
		static OverrideGhostMaterial()
		{
			Il2CppClassPointerStore<OverrideGhostMaterial>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Building", "OverrideGhostMaterial");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OverrideGhostMaterial>.NativeClassPtr);
			OverrideGhostMaterial.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OverrideGhostMaterial>.NativeClassPtr, 100676826);
		}

		// Token: 0x06006AB7 RID: 27319 RVA: 0x001DC5C8 File Offset: 0x001DA7C8
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OverrideGhostMaterial() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OverrideGhostMaterial>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OverrideGhostMaterial.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006AB8 RID: 27320 RVA: 0x00032761 File Offset: 0x00030961
		public OverrideGhostMaterial(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04004909 RID: 18697
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
