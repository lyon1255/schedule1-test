using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Doors
{
	// Token: 0x02000426 RID: 1062
	public class PivotDoor : MonoBehaviour
	{
		// Token: 0x06005D72 RID: 23922 RVA: 0x001AF574 File Offset: 0x001AD774
		// Note: this type is marked as 'beforefieldinit'.
		static PivotDoor()
		{
			Il2CppClassPointerStore<PivotDoor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Doors", "PivotDoor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PivotDoor>.NativeClassPtr);
			PivotDoor.NativeFieldInfoPtr_DoorTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PivotDoor>.NativeClassPtr, "DoorTransform");
			PivotDoor.NativeFieldInfoPtr_FlipSide = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PivotDoor>.NativeClassPtr, "FlipSide");
			PivotDoor.NativeFieldInfoPtr_OpenInwardsAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PivotDoor>.NativeClassPtr, "OpenInwardsAngle");
			PivotDoor.NativeFieldInfoPtr_OpenOutwardsAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PivotDoor>.NativeClassPtr, "OpenOutwardsAngle");
			PivotDoor.NativeFieldInfoPtr_SwingSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PivotDoor>.NativeClassPtr, "SwingSpeed");
			PivotDoor.NativeFieldInfoPtr_targetDoorAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PivotDoor>.NativeClassPtr, "targetDoorAngle");
			PivotDoor.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PivotDoor>.NativeClassPtr, 100675198);
			PivotDoor.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PivotDoor>.NativeClassPtr, 100675199);
			PivotDoor.NativeMethodInfoPtr_Opened_Public_Virtual_New_Void_EDoorSide_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PivotDoor>.NativeClassPtr, 100675200);
			PivotDoor.NativeMethodInfoPtr_Closed_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PivotDoor>.NativeClassPtr, 100675201);
			PivotDoor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PivotDoor>.NativeClassPtr, 100675202);
		}

		// Token: 0x06005D73 RID: 23923 RVA: 0x001AF680 File Offset: 0x001AD880
		[CallerCount(13604)]
		[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PivotDoor.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D74 RID: 23924 RVA: 0x001AF6BC File Offset: 0x001AD8BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195932, XrefRangeEnd = 195937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PivotDoor.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D75 RID: 23925 RVA: 0x001AF6F0 File Offset: 0x001AD8F0
		[CallerCount(0)]
		public unsafe virtual void Opened(EDoorSide openSide)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref openSide;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PivotDoor.NativeMethodInfoPtr_Opened_Public_Virtual_New_Void_EDoorSide_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D76 RID: 23926 RVA: 0x001AF73C File Offset: 0x001AD93C
		[CallerCount(0)]
		public unsafe virtual void Closed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PivotDoor.NativeMethodInfoPtr_Closed_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D77 RID: 23927 RVA: 0x001AF778 File Offset: 0x001AD978
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195937, XrefRangeEnd = 195938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PivotDoor() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PivotDoor>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PivotDoor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005D78 RID: 23928 RVA: 0x0002C0A4 File Offset: 0x0002A2A4
		public PivotDoor(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001C20 RID: 7200
		// (get) Token: 0x06005D79 RID: 23929 RVA: 0x001AF7B4 File Offset: 0x001AD9B4
		// (set) Token: 0x06005D7A RID: 23930 RVA: 0x0002C0AD File Offset: 0x0002A2AD
		public unsafe Transform DoorTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PivotDoor.NativeFieldInfoPtr_DoorTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PivotDoor.NativeFieldInfoPtr_DoorTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C21 RID: 7201
		// (get) Token: 0x06005D7B RID: 23931 RVA: 0x001AF7E4 File Offset: 0x001AD9E4
		// (set) Token: 0x06005D7C RID: 23932 RVA: 0x0002C0CC File Offset: 0x0002A2CC
		public unsafe bool FlipSide
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PivotDoor.NativeFieldInfoPtr_FlipSide);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PivotDoor.NativeFieldInfoPtr_FlipSide)) = value;
			}
		}

		// Token: 0x17001C22 RID: 7202
		// (get) Token: 0x06005D7D RID: 23933 RVA: 0x001AF80C File Offset: 0x001ADA0C
		// (set) Token: 0x06005D7E RID: 23934 RVA: 0x0002C0E7 File Offset: 0x0002A2E7
		public unsafe float OpenInwardsAngle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PivotDoor.NativeFieldInfoPtr_OpenInwardsAngle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PivotDoor.NativeFieldInfoPtr_OpenInwardsAngle)) = value;
			}
		}

		// Token: 0x17001C23 RID: 7203
		// (get) Token: 0x06005D7F RID: 23935 RVA: 0x001AF834 File Offset: 0x001ADA34
		// (set) Token: 0x06005D80 RID: 23936 RVA: 0x0002C102 File Offset: 0x0002A302
		public unsafe float OpenOutwardsAngle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PivotDoor.NativeFieldInfoPtr_OpenOutwardsAngle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PivotDoor.NativeFieldInfoPtr_OpenOutwardsAngle)) = value;
			}
		}

		// Token: 0x17001C24 RID: 7204
		// (get) Token: 0x06005D81 RID: 23937 RVA: 0x001AF85C File Offset: 0x001ADA5C
		// (set) Token: 0x06005D82 RID: 23938 RVA: 0x0002C11D File Offset: 0x0002A31D
		public unsafe float SwingSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PivotDoor.NativeFieldInfoPtr_SwingSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PivotDoor.NativeFieldInfoPtr_SwingSpeed)) = value;
			}
		}

		// Token: 0x17001C25 RID: 7205
		// (get) Token: 0x06005D83 RID: 23939 RVA: 0x001AF884 File Offset: 0x001ADA84
		// (set) Token: 0x06005D84 RID: 23940 RVA: 0x0002C138 File Offset: 0x0002A338
		public unsafe float targetDoorAngle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PivotDoor.NativeFieldInfoPtr_targetDoorAngle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PivotDoor.NativeFieldInfoPtr_targetDoorAngle)) = value;
			}
		}

		// Token: 0x04003FF5 RID: 16373
		private static readonly IntPtr NativeFieldInfoPtr_DoorTransform;

		// Token: 0x04003FF6 RID: 16374
		private static readonly IntPtr NativeFieldInfoPtr_FlipSide;

		// Token: 0x04003FF7 RID: 16375
		private static readonly IntPtr NativeFieldInfoPtr_OpenInwardsAngle;

		// Token: 0x04003FF8 RID: 16376
		private static readonly IntPtr NativeFieldInfoPtr_OpenOutwardsAngle;

		// Token: 0x04003FF9 RID: 16377
		private static readonly IntPtr NativeFieldInfoPtr_SwingSpeed;

		// Token: 0x04003FFA RID: 16378
		private static readonly IntPtr NativeFieldInfoPtr_targetDoorAngle;

		// Token: 0x04003FFB RID: 16379
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x04003FFC RID: 16380
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x04003FFD RID: 16381
		private static readonly IntPtr NativeMethodInfoPtr_Opened_Public_Virtual_New_Void_EDoorSide_0;

		// Token: 0x04003FFE RID: 16382
		private static readonly IntPtr NativeMethodInfoPtr_Closed_Public_Virtual_New_Void_0;

		// Token: 0x04003FFF RID: 16383
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
