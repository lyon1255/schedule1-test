using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.PlayerTasks;
using UnityEngine;

namespace Il2CppScheduleOne.ObjectScripts
{
	// Token: 0x02000741 RID: 1857
	public class LabStand : MonoBehaviour
	{
		// Token: 0x0600AC3C RID: 44092 RVA: 0x002AFFEC File Offset: 0x002AE1EC
		// Note: this type is marked as 'beforefieldinit'.
		static LabStand()
		{
			Il2CppClassPointerStore<LabStand>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts", "LabStand");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LabStand>.NativeClassPtr);
			LabStand.NativeFieldInfoPtr__Interactable_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabStand>.NativeClassPtr, "<Interactable>k__BackingField");
			LabStand.NativeFieldInfoPtr__CurrentPosition_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabStand>.NativeClassPtr, "<CurrentPosition>k__BackingField");
			LabStand.NativeFieldInfoPtr_MoveSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabStand>.NativeClassPtr, "MoveSpeed");
			LabStand.NativeFieldInfoPtr_FunnelEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabStand>.NativeClassPtr, "FunnelEnabled");
			LabStand.NativeFieldInfoPtr_FunnelThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabStand>.NativeClassPtr, "FunnelThreshold");
			LabStand.NativeFieldInfoPtr_Anim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabStand>.NativeClassPtr, "Anim");
			LabStand.NativeFieldInfoPtr_GripTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabStand>.NativeClassPtr, "GripTransform");
			LabStand.NativeFieldInfoPtr_SpinnyThingy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabStand>.NativeClassPtr, "SpinnyThingy");
			LabStand.NativeFieldInfoPtr_RaisedTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabStand>.NativeClassPtr, "RaisedTransform");
			LabStand.NativeFieldInfoPtr_LoweredTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabStand>.NativeClassPtr, "LoweredTransform");
			LabStand.NativeFieldInfoPtr_PlaneNormal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabStand>.NativeClassPtr, "PlaneNormal");
			LabStand.NativeFieldInfoPtr_HandleClickable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabStand>.NativeClassPtr, "HandleClickable");
			LabStand.NativeFieldInfoPtr_Funnel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabStand>.NativeClassPtr, "Funnel");
			LabStand.NativeFieldInfoPtr_Highlight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabStand>.NativeClassPtr, "Highlight");
			LabStand.NativeFieldInfoPtr_LowerSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabStand>.NativeClassPtr, "LowerSound");
			LabStand.NativeFieldInfoPtr_RaiseSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabStand>.NativeClassPtr, "RaiseSound");
			LabStand.NativeFieldInfoPtr_clickOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabStand>.NativeClassPtr, "clickOffset");
			LabStand.NativeFieldInfoPtr_isMoving = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabStand>.NativeClassPtr, "isMoving");
			LabStand.NativeMethodInfoPtr_get_Interactable_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabStand>.NativeClassPtr, 100684447);
			LabStand.NativeMethodInfoPtr_set_Interactable_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabStand>.NativeClassPtr, 100684448);
			LabStand.NativeMethodInfoPtr_get_CurrentPosition_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabStand>.NativeClassPtr, 100684449);
			LabStand.NativeMethodInfoPtr_set_CurrentPosition_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabStand>.NativeClassPtr, 100684450);
			LabStand.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabStand>.NativeClassPtr, 100684451);
			LabStand.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabStand>.NativeClassPtr, 100684452);
			LabStand.NativeMethodInfoPtr_Move_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabStand>.NativeClassPtr, 100684453);
			LabStand.NativeMethodInfoPtr_UpdateSound_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabStand>.NativeClassPtr, 100684454);
			LabStand.NativeMethodInfoPtr_SetPosition_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabStand>.NativeClassPtr, 100684455);
			LabStand.NativeMethodInfoPtr_SetInteractable_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabStand>.NativeClassPtr, 100684456);
			LabStand.NativeMethodInfoPtr_ClickStart_Public_Void_RaycastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabStand>.NativeClassPtr, 100684457);
			LabStand.NativeMethodInfoPtr_GetPlaneHit_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabStand>.NativeClassPtr, 100684458);
			LabStand.NativeMethodInfoPtr_ClickEnd_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabStand>.NativeClassPtr, 100684459);
			LabStand.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabStand>.NativeClassPtr, 100684460);
		}

		// Token: 0x17003562 RID: 13666
		// (get) Token: 0x0600AC3D RID: 44093 RVA: 0x002B029C File Offset: 0x002AE49C
		// (set) Token: 0x0600AC3E RID: 44094 RVA: 0x002B02D8 File Offset: 0x002AE4D8
		public unsafe bool Interactable
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 35361, RefRangeEnd = 35362, XrefRangeStart = 35361, XrefRangeEnd = 35362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabStand.NativeMethodInfoPtr_get_Interactable_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 35362, RefRangeEnd = 35364, XrefRangeStart = 35362, XrefRangeEnd = 35364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabStand.NativeMethodInfoPtr_set_Interactable_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17003563 RID: 13667
		// (get) Token: 0x0600AC3F RID: 44095 RVA: 0x002B0318 File Offset: 0x002AE518
		// (set) Token: 0x0600AC40 RID: 44096 RVA: 0x002B0354 File Offset: 0x002AE554
		public unsafe float CurrentPosition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabStand.NativeMethodInfoPtr_get_CurrentPosition_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 29976, RefRangeEnd = 29987, XrefRangeStart = 29976, XrefRangeEnd = 29987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabStand.NativeMethodInfoPtr_set_CurrentPosition_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600AC41 RID: 44097 RVA: 0x002B0394 File Offset: 0x002AE594
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298529, XrefRangeEnd = 298549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabStand.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AC42 RID: 44098 RVA: 0x002B03C8 File Offset: 0x002AE5C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298549, XrefRangeEnd = 298563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabStand.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AC43 RID: 44099 RVA: 0x002B03FC File Offset: 0x002AE5FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 298586, RefRangeEnd = 298587, XrefRangeStart = 298563, XrefRangeEnd = 298586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Move()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabStand.NativeMethodInfoPtr_Move_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AC44 RID: 44100 RVA: 0x002B0430 File Offset: 0x002AE630
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298587, XrefRangeEnd = 298591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateSound(float difference)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref difference;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabStand.NativeMethodInfoPtr_UpdateSound_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AC45 RID: 44101 RVA: 0x002B0470 File Offset: 0x002AE670
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 29976, RefRangeEnd = 29987, XrefRangeStart = 29976, XrefRangeEnd = 29987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPosition(float position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabStand.NativeMethodInfoPtr_SetPosition_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AC46 RID: 44102 RVA: 0x002B04B0 File Offset: 0x002AE6B0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 298594, RefRangeEnd = 298600, XrefRangeStart = 298591, XrefRangeEnd = 298594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetInteractable(bool e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref e;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabStand.NativeMethodInfoPtr_SetInteractable_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AC47 RID: 44103 RVA: 0x002B04F0 File Offset: 0x002AE6F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298600, XrefRangeEnd = 298603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClickStart(RaycastHit hit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref hit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabStand.NativeMethodInfoPtr_ClickStart_Public_Void_RaycastHit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AC48 RID: 44104 RVA: 0x002B0530 File Offset: 0x002AE730
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 298616, RefRangeEnd = 298618, XrefRangeStart = 298603, XrefRangeEnd = 298616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetPlaneHit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabStand.NativeMethodInfoPtr_GetPlaneHit_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600AC49 RID: 44105 RVA: 0x002B056C File Offset: 0x002AE76C
		[CallerCount(0)]
		public unsafe void ClickEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabStand.NativeMethodInfoPtr_ClickEnd_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AC4A RID: 44106 RVA: 0x002B05A0 File Offset: 0x002AE7A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298618, XrefRangeEnd = 298621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LabStand() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LabStand>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabStand.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AC4B RID: 44107 RVA: 0x00054B4B File Offset: 0x00052D4B
		public LabStand(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003550 RID: 13648
		// (get) Token: 0x0600AC4C RID: 44108 RVA: 0x002B05DC File Offset: 0x002AE7DC
		// (set) Token: 0x0600AC4D RID: 44109 RVA: 0x00054B54 File Offset: 0x00052D54
		public unsafe bool _Interactable_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabStand.NativeFieldInfoPtr__Interactable_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabStand.NativeFieldInfoPtr__Interactable_k__BackingField)) = value;
			}
		}

		// Token: 0x17003551 RID: 13649
		// (get) Token: 0x0600AC4E RID: 44110 RVA: 0x002B0604 File Offset: 0x002AE804
		// (set) Token: 0x0600AC4F RID: 44111 RVA: 0x00054B6F File Offset: 0x00052D6F
		public unsafe float _CurrentPosition_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabStand.NativeFieldInfoPtr__CurrentPosition_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabStand.NativeFieldInfoPtr__CurrentPosition_k__BackingField)) = value;
			}
		}

		// Token: 0x17003552 RID: 13650
		// (get) Token: 0x0600AC50 RID: 44112 RVA: 0x002B062C File Offset: 0x002AE82C
		// (set) Token: 0x0600AC51 RID: 44113 RVA: 0x00054B8A File Offset: 0x00052D8A
		public unsafe float MoveSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabStand.NativeFieldInfoPtr_MoveSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabStand.NativeFieldInfoPtr_MoveSpeed)) = value;
			}
		}

		// Token: 0x17003553 RID: 13651
		// (get) Token: 0x0600AC52 RID: 44114 RVA: 0x002B0654 File Offset: 0x002AE854
		// (set) Token: 0x0600AC53 RID: 44115 RVA: 0x00054BA5 File Offset: 0x00052DA5
		public unsafe bool FunnelEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabStand.NativeFieldInfoPtr_FunnelEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabStand.NativeFieldInfoPtr_FunnelEnabled)) = value;
			}
		}

		// Token: 0x17003554 RID: 13652
		// (get) Token: 0x0600AC54 RID: 44116 RVA: 0x002B067C File Offset: 0x002AE87C
		// (set) Token: 0x0600AC55 RID: 44117 RVA: 0x00054BC0 File Offset: 0x00052DC0
		public unsafe float FunnelThreshold
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabStand.NativeFieldInfoPtr_FunnelThreshold);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabStand.NativeFieldInfoPtr_FunnelThreshold)) = value;
			}
		}

		// Token: 0x17003555 RID: 13653
		// (get) Token: 0x0600AC56 RID: 44118 RVA: 0x002B06A4 File Offset: 0x002AE8A4
		// (set) Token: 0x0600AC57 RID: 44119 RVA: 0x00054BDB File Offset: 0x00052DDB
		public unsafe Animation Anim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabStand.NativeFieldInfoPtr_Anim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabStand.NativeFieldInfoPtr_Anim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003556 RID: 13654
		// (get) Token: 0x0600AC58 RID: 44120 RVA: 0x002B06D4 File Offset: 0x002AE8D4
		// (set) Token: 0x0600AC59 RID: 44121 RVA: 0x00054BFA File Offset: 0x00052DFA
		public unsafe Transform GripTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabStand.NativeFieldInfoPtr_GripTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabStand.NativeFieldInfoPtr_GripTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003557 RID: 13655
		// (get) Token: 0x0600AC5A RID: 44122 RVA: 0x002B0704 File Offset: 0x002AE904
		// (set) Token: 0x0600AC5B RID: 44123 RVA: 0x00054C19 File Offset: 0x00052E19
		public unsafe Transform SpinnyThingy
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabStand.NativeFieldInfoPtr_SpinnyThingy);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabStand.NativeFieldInfoPtr_SpinnyThingy), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003558 RID: 13656
		// (get) Token: 0x0600AC5C RID: 44124 RVA: 0x002B0734 File Offset: 0x002AE934
		// (set) Token: 0x0600AC5D RID: 44125 RVA: 0x00054C38 File Offset: 0x00052E38
		public unsafe Transform RaisedTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabStand.NativeFieldInfoPtr_RaisedTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabStand.NativeFieldInfoPtr_RaisedTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003559 RID: 13657
		// (get) Token: 0x0600AC5E RID: 44126 RVA: 0x002B0764 File Offset: 0x002AE964
		// (set) Token: 0x0600AC5F RID: 44127 RVA: 0x00054C57 File Offset: 0x00052E57
		public unsafe Transform LoweredTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabStand.NativeFieldInfoPtr_LoweredTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabStand.NativeFieldInfoPtr_LoweredTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700355A RID: 13658
		// (get) Token: 0x0600AC60 RID: 44128 RVA: 0x002B0794 File Offset: 0x002AE994
		// (set) Token: 0x0600AC61 RID: 44129 RVA: 0x00054C76 File Offset: 0x00052E76
		public unsafe Transform PlaneNormal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabStand.NativeFieldInfoPtr_PlaneNormal);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabStand.NativeFieldInfoPtr_PlaneNormal), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700355B RID: 13659
		// (get) Token: 0x0600AC62 RID: 44130 RVA: 0x002B07C4 File Offset: 0x002AE9C4
		// (set) Token: 0x0600AC63 RID: 44131 RVA: 0x00054C95 File Offset: 0x00052E95
		public unsafe Clickable HandleClickable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabStand.NativeFieldInfoPtr_HandleClickable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Clickable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabStand.NativeFieldInfoPtr_HandleClickable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700355C RID: 13660
		// (get) Token: 0x0600AC64 RID: 44132 RVA: 0x002B07F4 File Offset: 0x002AE9F4
		// (set) Token: 0x0600AC65 RID: 44133 RVA: 0x00054CB4 File Offset: 0x00052EB4
		public unsafe Transform Funnel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabStand.NativeFieldInfoPtr_Funnel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabStand.NativeFieldInfoPtr_Funnel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700355D RID: 13661
		// (get) Token: 0x0600AC66 RID: 44134 RVA: 0x002B0824 File Offset: 0x002AEA24
		// (set) Token: 0x0600AC67 RID: 44135 RVA: 0x00054CD3 File Offset: 0x00052ED3
		public unsafe GameObject Highlight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabStand.NativeFieldInfoPtr_Highlight);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabStand.NativeFieldInfoPtr_Highlight), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700355E RID: 13662
		// (get) Token: 0x0600AC68 RID: 44136 RVA: 0x002B0854 File Offset: 0x002AEA54
		// (set) Token: 0x0600AC69 RID: 44137 RVA: 0x00054CF2 File Offset: 0x00052EF2
		public unsafe AudioSourceController LowerSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabStand.NativeFieldInfoPtr_LowerSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabStand.NativeFieldInfoPtr_LowerSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700355F RID: 13663
		// (get) Token: 0x0600AC6A RID: 44138 RVA: 0x002B0884 File Offset: 0x002AEA84
		// (set) Token: 0x0600AC6B RID: 44139 RVA: 0x00054D11 File Offset: 0x00052F11
		public unsafe AudioSourceController RaiseSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabStand.NativeFieldInfoPtr_RaiseSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabStand.NativeFieldInfoPtr_RaiseSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003560 RID: 13664
		// (get) Token: 0x0600AC6C RID: 44140 RVA: 0x002B08B4 File Offset: 0x002AEAB4
		// (set) Token: 0x0600AC6D RID: 44141 RVA: 0x00054D30 File Offset: 0x00052F30
		public unsafe Vector3 clickOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabStand.NativeFieldInfoPtr_clickOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabStand.NativeFieldInfoPtr_clickOffset)) = value;
			}
		}

		// Token: 0x17003561 RID: 13665
		// (get) Token: 0x0600AC6E RID: 44142 RVA: 0x002B08DC File Offset: 0x002AEADC
		// (set) Token: 0x0600AC6F RID: 44143 RVA: 0x00054D4B File Offset: 0x00052F4B
		public unsafe bool isMoving
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabStand.NativeFieldInfoPtr_isMoving);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabStand.NativeFieldInfoPtr_isMoving)) = value;
			}
		}

		// Token: 0x040073CC RID: 29644
		private static readonly IntPtr NativeFieldInfoPtr__Interactable_k__BackingField;

		// Token: 0x040073CD RID: 29645
		private static readonly IntPtr NativeFieldInfoPtr__CurrentPosition_k__BackingField;

		// Token: 0x040073CE RID: 29646
		private static readonly IntPtr NativeFieldInfoPtr_MoveSpeed;

		// Token: 0x040073CF RID: 29647
		private static readonly IntPtr NativeFieldInfoPtr_FunnelEnabled;

		// Token: 0x040073D0 RID: 29648
		private static readonly IntPtr NativeFieldInfoPtr_FunnelThreshold;

		// Token: 0x040073D1 RID: 29649
		private static readonly IntPtr NativeFieldInfoPtr_Anim;

		// Token: 0x040073D2 RID: 29650
		private static readonly IntPtr NativeFieldInfoPtr_GripTransform;

		// Token: 0x040073D3 RID: 29651
		private static readonly IntPtr NativeFieldInfoPtr_SpinnyThingy;

		// Token: 0x040073D4 RID: 29652
		private static readonly IntPtr NativeFieldInfoPtr_RaisedTransform;

		// Token: 0x040073D5 RID: 29653
		private static readonly IntPtr NativeFieldInfoPtr_LoweredTransform;

		// Token: 0x040073D6 RID: 29654
		private static readonly IntPtr NativeFieldInfoPtr_PlaneNormal;

		// Token: 0x040073D7 RID: 29655
		private static readonly IntPtr NativeFieldInfoPtr_HandleClickable;

		// Token: 0x040073D8 RID: 29656
		private static readonly IntPtr NativeFieldInfoPtr_Funnel;

		// Token: 0x040073D9 RID: 29657
		private static readonly IntPtr NativeFieldInfoPtr_Highlight;

		// Token: 0x040073DA RID: 29658
		private static readonly IntPtr NativeFieldInfoPtr_LowerSound;

		// Token: 0x040073DB RID: 29659
		private static readonly IntPtr NativeFieldInfoPtr_RaiseSound;

		// Token: 0x040073DC RID: 29660
		private static readonly IntPtr NativeFieldInfoPtr_clickOffset;

		// Token: 0x040073DD RID: 29661
		private static readonly IntPtr NativeFieldInfoPtr_isMoving;

		// Token: 0x040073DE RID: 29662
		private static readonly IntPtr NativeMethodInfoPtr_get_Interactable_Public_get_Boolean_0;

		// Token: 0x040073DF RID: 29663
		private static readonly IntPtr NativeMethodInfoPtr_set_Interactable_Private_set_Void_Boolean_0;

		// Token: 0x040073E0 RID: 29664
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentPosition_Public_get_Single_0;

		// Token: 0x040073E1 RID: 29665
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentPosition_Private_set_Void_Single_0;

		// Token: 0x040073E2 RID: 29666
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040073E3 RID: 29667
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x040073E4 RID: 29668
		private static readonly IntPtr NativeMethodInfoPtr_Move_Private_Void_0;

		// Token: 0x040073E5 RID: 29669
		private static readonly IntPtr NativeMethodInfoPtr_UpdateSound_Private_Void_Single_0;

		// Token: 0x040073E6 RID: 29670
		private static readonly IntPtr NativeMethodInfoPtr_SetPosition_Public_Void_Single_0;

		// Token: 0x040073E7 RID: 29671
		private static readonly IntPtr NativeMethodInfoPtr_SetInteractable_Public_Void_Boolean_0;

		// Token: 0x040073E8 RID: 29672
		private static readonly IntPtr NativeMethodInfoPtr_ClickStart_Public_Void_RaycastHit_0;

		// Token: 0x040073E9 RID: 29673
		private static readonly IntPtr NativeMethodInfoPtr_GetPlaneHit_Private_Vector3_0;

		// Token: 0x040073EA RID: 29674
		private static readonly IntPtr NativeMethodInfoPtr_ClickEnd_Public_Void_0;

		// Token: 0x040073EB RID: 29675
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
