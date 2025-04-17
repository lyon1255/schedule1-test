using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Vehicles.Recording
{
	// Token: 0x020004F5 RID: 1269
	[Serializable]
	public class DrivePath : ScriptableObject
	{
		// Token: 0x06007063 RID: 28771 RVA: 0x001EE5B4 File Offset: 0x001EC7B4
		// Note: this type is marked as 'beforefieldinit'.
		static DrivePath()
		{
			Il2CppClassPointerStore<DrivePath>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vehicles.Recording", "DrivePath");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DrivePath>.NativeClassPtr);
			DrivePath.NativeFieldInfoPtr_fps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrivePath>.NativeClassPtr, "fps");
			DrivePath.NativeFieldInfoPtr_keyframes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrivePath>.NativeClassPtr, "keyframes");
			DrivePath.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrivePath>.NativeClassPtr, 100677428);
		}

		// Token: 0x06007064 RID: 28772 RVA: 0x001EE620 File Offset: 0x001EC820
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221408, XrefRangeEnd = 221416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DrivePath() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DrivePath>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrivePath.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007065 RID: 28773 RVA: 0x0003555B File Offset: 0x0003375B
		public DrivePath(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170021F6 RID: 8694
		// (get) Token: 0x06007066 RID: 28774 RVA: 0x001EE65C File Offset: 0x001EC85C
		// (set) Token: 0x06007067 RID: 28775 RVA: 0x00035564 File Offset: 0x00033764
		public unsafe int fps
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrivePath.NativeFieldInfoPtr_fps);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrivePath.NativeFieldInfoPtr_fps)) = value;
			}
		}

		// Token: 0x170021F7 RID: 8695
		// (get) Token: 0x06007068 RID: 28776 RVA: 0x001EE684 File Offset: 0x001EC884
		// (set) Token: 0x06007069 RID: 28777 RVA: 0x0003557F File Offset: 0x0003377F
		public unsafe List<VehicleKeyFrame> keyframes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrivePath.NativeFieldInfoPtr_keyframes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<VehicleKeyFrame>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrivePath.NativeFieldInfoPtr_keyframes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004CC5 RID: 19653
		private static readonly IntPtr NativeFieldInfoPtr_fps;

		// Token: 0x04004CC6 RID: 19654
		private static readonly IntPtr NativeFieldInfoPtr_keyframes;

		// Token: 0x04004CC7 RID: 19655
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
