using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Vehicles
{
	// Token: 0x020004DE RID: 1246
	public class ForkliftFork : MonoBehaviour
	{
		// Token: 0x06006CF8 RID: 27896 RVA: 0x001E32DC File Offset: 0x001E14DC
		// Note: this type is marked as 'beforefieldinit'.
		static ForkliftFork()
		{
			Il2CppClassPointerStore<ForkliftFork>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vehicles", "ForkliftFork");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ForkliftFork>.NativeClassPtr);
			ForkliftFork.NativeFieldInfoPtr_forklift = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForkliftFork>.NativeClassPtr, "forklift");
			ForkliftFork.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForkliftFork>.NativeClassPtr, 100677069);
		}

		// Token: 0x06006CF9 RID: 27897 RVA: 0x001E3334 File Offset: 0x001E1534
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ForkliftFork() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ForkliftFork>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ForkliftFork.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006CFA RID: 27898 RVA: 0x00033957 File Offset: 0x00031B57
		public ForkliftFork(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170020C0 RID: 8384
		// (get) Token: 0x06006CFB RID: 27899 RVA: 0x001E3370 File Offset: 0x001E1570
		// (set) Token: 0x06006CFC RID: 27900 RVA: 0x00033960 File Offset: 0x00031B60
		public unsafe Forklift forklift
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForkliftFork.NativeFieldInfoPtr_forklift);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Forklift>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForkliftFork.NativeFieldInfoPtr_forklift), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004A7C RID: 19068
		private static readonly IntPtr NativeFieldInfoPtr_forklift;

		// Token: 0x04004A7D RID: 19069
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
