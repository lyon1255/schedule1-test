using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Doors
{
	// Token: 0x02000424 RID: 1060
	public class DoorSensor : MonoBehaviour
	{
		// Token: 0x06005D57 RID: 23895 RVA: 0x001AF0F8 File Offset: 0x001AD2F8
		// Note: this type is marked as 'beforefieldinit'.
		static DoorSensor()
		{
			Il2CppClassPointerStore<DoorSensor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Doors", "DoorSensor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DoorSensor>.NativeClassPtr);
			DoorSensor.NativeFieldInfoPtr_ActivationDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorSensor>.NativeClassPtr, "ActivationDistance");
			DoorSensor.NativeFieldInfoPtr_DetectorSide = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorSensor>.NativeClassPtr, "DetectorSide");
			DoorSensor.NativeFieldInfoPtr_Door = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorSensor>.NativeClassPtr, "Door");
			DoorSensor.NativeFieldInfoPtr_exclude = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorSensor>.NativeClassPtr, "exclude");
			DoorSensor.NativeFieldInfoPtr_collider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DoorSensor>.NativeClassPtr, "collider");
			DoorSensor.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorSensor>.NativeClassPtr, 100675191);
			DoorSensor.NativeMethodInfoPtr_UpdateCollider_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorSensor>.NativeClassPtr, 100675192);
			DoorSensor.NativeMethodInfoPtr_OnTriggerStay_Private_Void_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorSensor>.NativeClassPtr, 100675193);
			DoorSensor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DoorSensor>.NativeClassPtr, 100675194);
		}

		// Token: 0x06005D58 RID: 23896 RVA: 0x001AF1DC File Offset: 0x001AD3DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195866, XrefRangeEnd = 195873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoorSensor.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D59 RID: 23897 RVA: 0x001AF210 File Offset: 0x001AD410
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195873, XrefRangeEnd = 195901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateCollider()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoorSensor.NativeMethodInfoPtr_UpdateCollider_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D5A RID: 23898 RVA: 0x001AF244 File Offset: 0x001AD444
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195901, XrefRangeEnd = 195914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTriggerStay(Collider other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoorSensor.NativeMethodInfoPtr_OnTriggerStay_Private_Void_Collider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D5B RID: 23899 RVA: 0x001AF288 File Offset: 0x001AD488
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195914, XrefRangeEnd = 195922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DoorSensor() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DoorSensor>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DoorSensor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D5C RID: 23900 RVA: 0x0002BFAF File Offset: 0x0002A1AF
		public DoorSensor(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001C18 RID: 7192
		// (get) Token: 0x06005D5D RID: 23901 RVA: 0x001AF2C4 File Offset: 0x001AD4C4
		// (set) Token: 0x06005D5E RID: 23902 RVA: 0x0002BFB8 File Offset: 0x0002A1B8
		public unsafe static float ActivationDistance
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(DoorSensor.NativeFieldInfoPtr_ActivationDistance, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DoorSensor.NativeFieldInfoPtr_ActivationDistance, (void*)(&value));
			}
		}

		// Token: 0x17001C19 RID: 7193
		// (get) Token: 0x06005D5F RID: 23903 RVA: 0x001AF2E0 File Offset: 0x001AD4E0
		// (set) Token: 0x06005D60 RID: 23904 RVA: 0x0002BFC6 File Offset: 0x0002A1C6
		public unsafe EDoorSide DetectorSide
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorSensor.NativeFieldInfoPtr_DetectorSide);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorSensor.NativeFieldInfoPtr_DetectorSide)) = value;
			}
		}

		// Token: 0x17001C1A RID: 7194
		// (get) Token: 0x06005D61 RID: 23905 RVA: 0x001AF308 File Offset: 0x001AD508
		// (set) Token: 0x06005D62 RID: 23906 RVA: 0x0002BFE1 File Offset: 0x0002A1E1
		public unsafe DoorController Door
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorSensor.NativeFieldInfoPtr_Door);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DoorController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorSensor.NativeFieldInfoPtr_Door), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C1B RID: 7195
		// (get) Token: 0x06005D63 RID: 23907 RVA: 0x001AF338 File Offset: 0x001AD538
		// (set) Token: 0x06005D64 RID: 23908 RVA: 0x0002C000 File Offset: 0x0002A200
		public unsafe List<Collider> exclude
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorSensor.NativeFieldInfoPtr_exclude);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Collider>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorSensor.NativeFieldInfoPtr_exclude), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C1C RID: 7196
		// (get) Token: 0x06005D65 RID: 23909 RVA: 0x001AF368 File Offset: 0x001AD568
		// (set) Token: 0x06005D66 RID: 23910 RVA: 0x0002C01F File Offset: 0x0002A21F
		public unsafe Collider collider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorSensor.NativeFieldInfoPtr_collider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Collider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DoorSensor.NativeFieldInfoPtr_collider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003FE6 RID: 16358
		private static readonly IntPtr NativeFieldInfoPtr_ActivationDistance;

		// Token: 0x04003FE7 RID: 16359
		private static readonly IntPtr NativeFieldInfoPtr_DetectorSide;

		// Token: 0x04003FE8 RID: 16360
		private static readonly IntPtr NativeFieldInfoPtr_Door;

		// Token: 0x04003FE9 RID: 16361
		private static readonly IntPtr NativeFieldInfoPtr_exclude;

		// Token: 0x04003FEA RID: 16362
		private static readonly IntPtr NativeFieldInfoPtr_collider;

		// Token: 0x04003FEB RID: 16363
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04003FEC RID: 16364
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCollider_Private_Void_0;

		// Token: 0x04003FED RID: 16365
		private static readonly IntPtr NativeMethodInfoPtr_OnTriggerStay_Private_Void_Collider_0;

		// Token: 0x04003FEE RID: 16366
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
