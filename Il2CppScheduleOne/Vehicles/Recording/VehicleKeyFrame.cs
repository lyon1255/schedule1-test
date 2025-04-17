using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Vehicles.Recording
{
	// Token: 0x020004F6 RID: 1270
	[Serializable]
	public class VehicleKeyFrame : Il2CppSystem.Object
	{
		// Token: 0x0600706A RID: 28778 RVA: 0x001EE6B4 File Offset: 0x001EC8B4
		// Note: this type is marked as 'beforefieldinit'.
		static VehicleKeyFrame()
		{
			Il2CppClassPointerStore<VehicleKeyFrame>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vehicles.Recording", "VehicleKeyFrame");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VehicleKeyFrame>.NativeClassPtr);
			VehicleKeyFrame.NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleKeyFrame>.NativeClassPtr, "position");
			VehicleKeyFrame.NativeFieldInfoPtr_rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleKeyFrame>.NativeClassPtr, "rotation");
			VehicleKeyFrame.NativeFieldInfoPtr_brakesApplied = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleKeyFrame>.NativeClassPtr, "brakesApplied");
			VehicleKeyFrame.NativeFieldInfoPtr_reversing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleKeyFrame>.NativeClassPtr, "reversing");
			VehicleKeyFrame.NativeFieldInfoPtr_headlightsOn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleKeyFrame>.NativeClassPtr, "headlightsOn");
			VehicleKeyFrame.NativeFieldInfoPtr_wheels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleKeyFrame>.NativeClassPtr, "wheels");
			VehicleKeyFrame.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleKeyFrame>.NativeClassPtr, 100677429);
		}

		// Token: 0x0600706B RID: 28779 RVA: 0x001EE770 File Offset: 0x001EC970
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221416, XrefRangeEnd = 221424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VehicleKeyFrame() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VehicleKeyFrame>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleKeyFrame.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600706C RID: 28780 RVA: 0x0003559E File Offset: 0x0003379E
		public VehicleKeyFrame(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170021F8 RID: 8696
		// (get) Token: 0x0600706D RID: 28781 RVA: 0x001EE7AC File Offset: 0x001EC9AC
		// (set) Token: 0x0600706E RID: 28782 RVA: 0x000355A7 File Offset: 0x000337A7
		public unsafe Vector3 position
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleKeyFrame.NativeFieldInfoPtr_position);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleKeyFrame.NativeFieldInfoPtr_position)) = value;
			}
		}

		// Token: 0x170021F9 RID: 8697
		// (get) Token: 0x0600706F RID: 28783 RVA: 0x001EE7D4 File Offset: 0x001EC9D4
		// (set) Token: 0x06007070 RID: 28784 RVA: 0x000355C2 File Offset: 0x000337C2
		public unsafe Quaternion rotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleKeyFrame.NativeFieldInfoPtr_rotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleKeyFrame.NativeFieldInfoPtr_rotation)) = value;
			}
		}

		// Token: 0x170021FA RID: 8698
		// (get) Token: 0x06007071 RID: 28785 RVA: 0x001EE7FC File Offset: 0x001EC9FC
		// (set) Token: 0x06007072 RID: 28786 RVA: 0x000355DD File Offset: 0x000337DD
		public unsafe bool brakesApplied
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleKeyFrame.NativeFieldInfoPtr_brakesApplied);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleKeyFrame.NativeFieldInfoPtr_brakesApplied)) = value;
			}
		}

		// Token: 0x170021FB RID: 8699
		// (get) Token: 0x06007073 RID: 28787 RVA: 0x001EE824 File Offset: 0x001ECA24
		// (set) Token: 0x06007074 RID: 28788 RVA: 0x000355F8 File Offset: 0x000337F8
		public unsafe bool reversing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleKeyFrame.NativeFieldInfoPtr_reversing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleKeyFrame.NativeFieldInfoPtr_reversing)) = value;
			}
		}

		// Token: 0x170021FC RID: 8700
		// (get) Token: 0x06007075 RID: 28789 RVA: 0x001EE84C File Offset: 0x001ECA4C
		// (set) Token: 0x06007076 RID: 28790 RVA: 0x00035613 File Offset: 0x00033813
		public unsafe bool headlightsOn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleKeyFrame.NativeFieldInfoPtr_headlightsOn);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleKeyFrame.NativeFieldInfoPtr_headlightsOn)) = value;
			}
		}

		// Token: 0x170021FD RID: 8701
		// (get) Token: 0x06007077 RID: 28791 RVA: 0x001EE874 File Offset: 0x001ECA74
		// (set) Token: 0x06007078 RID: 28792 RVA: 0x0003562E File Offset: 0x0003382E
		public unsafe List<VehicleKeyFrame.WheelTransform> wheels
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleKeyFrame.NativeFieldInfoPtr_wheels);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<VehicleKeyFrame.WheelTransform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleKeyFrame.NativeFieldInfoPtr_wheels), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004CC8 RID: 19656
		private static readonly IntPtr NativeFieldInfoPtr_position;

		// Token: 0x04004CC9 RID: 19657
		private static readonly IntPtr NativeFieldInfoPtr_rotation;

		// Token: 0x04004CCA RID: 19658
		private static readonly IntPtr NativeFieldInfoPtr_brakesApplied;

		// Token: 0x04004CCB RID: 19659
		private static readonly IntPtr NativeFieldInfoPtr_reversing;

		// Token: 0x04004CCC RID: 19660
		private static readonly IntPtr NativeFieldInfoPtr_headlightsOn;

		// Token: 0x04004CCD RID: 19661
		private static readonly IntPtr NativeFieldInfoPtr_wheels;

		// Token: 0x04004CCE RID: 19662
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000A6C RID: 2668
		[Serializable]
		public class WheelTransform : Il2CppSystem.Object
		{
			// Token: 0x0600D122 RID: 53538 RVA: 0x00321B10 File Offset: 0x0031FD10
			// Note: this type is marked as 'beforefieldinit'.
			static WheelTransform()
			{
				Il2CppClassPointerStore<VehicleKeyFrame.WheelTransform>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VehicleKeyFrame>.NativeClassPtr, "WheelTransform");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VehicleKeyFrame.WheelTransform>.NativeClassPtr);
				VehicleKeyFrame.WheelTransform.NativeFieldInfoPtr_yPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleKeyFrame.WheelTransform>.NativeClassPtr, "yPos");
				VehicleKeyFrame.WheelTransform.NativeFieldInfoPtr_rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VehicleKeyFrame.WheelTransform>.NativeClassPtr, "rotation");
				VehicleKeyFrame.WheelTransform.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehicleKeyFrame.WheelTransform>.NativeClassPtr, 100677430);
			}

			// Token: 0x0600D123 RID: 53539 RVA: 0x00321B78 File Offset: 0x0031FD78
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe WheelTransform() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VehicleKeyFrame.WheelTransform>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehicleKeyFrame.WheelTransform.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D124 RID: 53540 RVA: 0x00065CF4 File Offset: 0x00063EF4
			public WheelTransform(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170040F0 RID: 16624
			// (get) Token: 0x0600D125 RID: 53541 RVA: 0x00321BB4 File Offset: 0x0031FDB4
			// (set) Token: 0x0600D126 RID: 53542 RVA: 0x00065CFD File Offset: 0x00063EFD
			public unsafe float yPos
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleKeyFrame.WheelTransform.NativeFieldInfoPtr_yPos);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleKeyFrame.WheelTransform.NativeFieldInfoPtr_yPos)) = value;
				}
			}

			// Token: 0x170040F1 RID: 16625
			// (get) Token: 0x0600D127 RID: 53543 RVA: 0x00321BDC File Offset: 0x0031FDDC
			// (set) Token: 0x0600D128 RID: 53544 RVA: 0x00065D18 File Offset: 0x00063F18
			public unsafe Quaternion rotation
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleKeyFrame.WheelTransform.NativeFieldInfoPtr_rotation);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VehicleKeyFrame.WheelTransform.NativeFieldInfoPtr_rotation)) = value;
				}
			}

			// Token: 0x04008D1B RID: 36123
			private static readonly IntPtr NativeFieldInfoPtr_yPos;

			// Token: 0x04008D1C RID: 36124
			private static readonly IntPtr NativeFieldInfoPtr_rotation;

			// Token: 0x04008D1D RID: 36125
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
