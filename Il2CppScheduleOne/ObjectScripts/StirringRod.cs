using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.PlayerTasks;
using UnityEngine;

namespace Il2CppScheduleOne.ObjectScripts
{
	// Token: 0x02000742 RID: 1858
	public class StirringRod : MonoBehaviour
	{
		// Token: 0x0600AC70 RID: 44144 RVA: 0x002B0904 File Offset: 0x002AEB04
		// Note: this type is marked as 'beforefieldinit'.
		static StirringRod()
		{
			Il2CppClassPointerStore<StirringRod>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts", "StirringRod");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StirringRod>.NativeClassPtr);
			StirringRod.NativeFieldInfoPtr_MAX_STIR_RATE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StirringRod>.NativeClassPtr, "MAX_STIR_RATE");
			StirringRod.NativeFieldInfoPtr_MAX_PIVOT_ANGLE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StirringRod>.NativeClassPtr, "MAX_PIVOT_ANGLE");
			StirringRod.NativeFieldInfoPtr__Interactable_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StirringRod>.NativeClassPtr, "<Interactable>k__BackingField");
			StirringRod.NativeFieldInfoPtr__CurrentStirringSpeed_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StirringRod>.NativeClassPtr, "<CurrentStirringSpeed>k__BackingField");
			StirringRod.NativeFieldInfoPtr_LerpSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StirringRod>.NativeClassPtr, "LerpSpeed");
			StirringRod.NativeFieldInfoPtr_Clickable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StirringRod>.NativeClassPtr, "Clickable");
			StirringRod.NativeFieldInfoPtr_PlaneNormal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StirringRod>.NativeClassPtr, "PlaneNormal");
			StirringRod.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StirringRod>.NativeClassPtr, "Container");
			StirringRod.NativeFieldInfoPtr_RodPivot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StirringRod>.NativeClassPtr, "RodPivot");
			StirringRod.NativeFieldInfoPtr_StirSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StirringRod>.NativeClassPtr, "StirSound");
			StirringRod.NativeFieldInfoPtr_clickOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StirringRod>.NativeClassPtr, "clickOffset");
			StirringRod.NativeFieldInfoPtr_isMoving = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StirringRod>.NativeClassPtr, "isMoving");
			StirringRod.NativeMethodInfoPtr_get_Interactable_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StirringRod>.NativeClassPtr, 100684461);
			StirringRod.NativeMethodInfoPtr_set_Interactable_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StirringRod>.NativeClassPtr, 100684462);
			StirringRod.NativeMethodInfoPtr_get_CurrentStirringSpeed_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StirringRod>.NativeClassPtr, 100684463);
			StirringRod.NativeMethodInfoPtr_set_CurrentStirringSpeed_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StirringRod>.NativeClassPtr, 100684464);
			StirringRod.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StirringRod>.NativeClassPtr, 100684465);
			StirringRod.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StirringRod>.NativeClassPtr, 100684466);
			StirringRod.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StirringRod>.NativeClassPtr, 100684467);
			StirringRod.NativeMethodInfoPtr_SetInteractable_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StirringRod>.NativeClassPtr, 100684468);
			StirringRod.NativeMethodInfoPtr_ClickStart_Public_Void_RaycastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StirringRod>.NativeClassPtr, 100684469);
			StirringRod.NativeMethodInfoPtr_GetPlaneHit_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StirringRod>.NativeClassPtr, 100684470);
			StirringRod.NativeMethodInfoPtr_ClickEnd_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StirringRod>.NativeClassPtr, 100684471);
			StirringRod.NativeMethodInfoPtr_Destroy_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StirringRod>.NativeClassPtr, 100684472);
			StirringRod.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StirringRod>.NativeClassPtr, 100684473);
		}

		// Token: 0x17003570 RID: 13680
		// (get) Token: 0x0600AC71 RID: 44145 RVA: 0x002B0B28 File Offset: 0x002AED28
		// (set) Token: 0x0600AC72 RID: 44146 RVA: 0x002B0B64 File Offset: 0x002AED64
		public unsafe bool Interactable
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 35361, RefRangeEnd = 35362, XrefRangeStart = 35361, XrefRangeEnd = 35362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StirringRod.NativeMethodInfoPtr_get_Interactable_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StirringRod.NativeMethodInfoPtr_set_Interactable_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17003571 RID: 13681
		// (get) Token: 0x0600AC73 RID: 44147 RVA: 0x002B0BA4 File Offset: 0x002AEDA4
		// (set) Token: 0x0600AC74 RID: 44148 RVA: 0x002B0BE0 File Offset: 0x002AEDE0
		public unsafe float CurrentStirringSpeed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StirringRod.NativeMethodInfoPtr_get_CurrentStirringSpeed_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StirringRod.NativeMethodInfoPtr_set_CurrentStirringSpeed_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600AC75 RID: 44149 RVA: 0x002B0C20 File Offset: 0x002AEE20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298621, XrefRangeEnd = 298638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StirringRod.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AC76 RID: 44150 RVA: 0x002B0C54 File Offset: 0x002AEE54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298638, XrefRangeEnd = 298642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StirringRod.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AC77 RID: 44151 RVA: 0x002B0C88 File Offset: 0x002AEE88
		[CallerCount(0)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StirringRod.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AC78 RID: 44152 RVA: 0x002B0CBC File Offset: 0x002AEEBC
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 298642, RefRangeEnd = 298657, XrefRangeStart = 298642, XrefRangeEnd = 298642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetInteractable(bool e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref e;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StirringRod.NativeMethodInfoPtr_SetInteractable_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AC79 RID: 44153 RVA: 0x002B0CFC File Offset: 0x002AEEFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298657, XrefRangeEnd = 298660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClickStart(RaycastHit hit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref hit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StirringRod.NativeMethodInfoPtr_ClickStart_Public_Void_RaycastHit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AC7A RID: 44154 RVA: 0x002B0D3C File Offset: 0x002AEF3C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 298673, RefRangeEnd = 298674, XrefRangeStart = 298660, XrefRangeEnd = 298673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetPlaneHit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StirringRod.NativeMethodInfoPtr_GetPlaneHit_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600AC7B RID: 44155 RVA: 0x002B0D78 File Offset: 0x002AEF78
		[CallerCount(0)]
		public unsafe void ClickEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StirringRod.NativeMethodInfoPtr_ClickEnd_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AC7C RID: 44156 RVA: 0x002B0DAC File Offset: 0x002AEFAC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 298679, RefRangeEnd = 298681, XrefRangeStart = 298674, XrefRangeEnd = 298679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Destroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StirringRod.NativeMethodInfoPtr_Destroy_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AC7D RID: 44157 RVA: 0x002B0DE0 File Offset: 0x002AEFE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 298681, XrefRangeEnd = 298684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StirringRod() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StirringRod>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StirringRod.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600AC7E RID: 44158 RVA: 0x00054D66 File Offset: 0x00052F66
		public StirringRod(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003564 RID: 13668
		// (get) Token: 0x0600AC7F RID: 44159 RVA: 0x002B0E1C File Offset: 0x002AF01C
		// (set) Token: 0x0600AC80 RID: 44160 RVA: 0x00054D6F File Offset: 0x00052F6F
		public unsafe static float MAX_STIR_RATE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(StirringRod.NativeFieldInfoPtr_MAX_STIR_RATE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StirringRod.NativeFieldInfoPtr_MAX_STIR_RATE, (void*)(&value));
			}
		}

		// Token: 0x17003565 RID: 13669
		// (get) Token: 0x0600AC81 RID: 44161 RVA: 0x002B0E38 File Offset: 0x002AF038
		// (set) Token: 0x0600AC82 RID: 44162 RVA: 0x00054D7D File Offset: 0x00052F7D
		public unsafe static float MAX_PIVOT_ANGLE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(StirringRod.NativeFieldInfoPtr_MAX_PIVOT_ANGLE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StirringRod.NativeFieldInfoPtr_MAX_PIVOT_ANGLE, (void*)(&value));
			}
		}

		// Token: 0x17003566 RID: 13670
		// (get) Token: 0x0600AC83 RID: 44163 RVA: 0x002B0E54 File Offset: 0x002AF054
		// (set) Token: 0x0600AC84 RID: 44164 RVA: 0x00054D8B File Offset: 0x00052F8B
		public unsafe bool _Interactable_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StirringRod.NativeFieldInfoPtr__Interactable_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StirringRod.NativeFieldInfoPtr__Interactable_k__BackingField)) = value;
			}
		}

		// Token: 0x17003567 RID: 13671
		// (get) Token: 0x0600AC85 RID: 44165 RVA: 0x002B0E7C File Offset: 0x002AF07C
		// (set) Token: 0x0600AC86 RID: 44166 RVA: 0x00054DA6 File Offset: 0x00052FA6
		public unsafe float _CurrentStirringSpeed_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StirringRod.NativeFieldInfoPtr__CurrentStirringSpeed_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StirringRod.NativeFieldInfoPtr__CurrentStirringSpeed_k__BackingField)) = value;
			}
		}

		// Token: 0x17003568 RID: 13672
		// (get) Token: 0x0600AC87 RID: 44167 RVA: 0x002B0EA4 File Offset: 0x002AF0A4
		// (set) Token: 0x0600AC88 RID: 44168 RVA: 0x00054DC1 File Offset: 0x00052FC1
		public unsafe float LerpSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StirringRod.NativeFieldInfoPtr_LerpSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StirringRod.NativeFieldInfoPtr_LerpSpeed)) = value;
			}
		}

		// Token: 0x17003569 RID: 13673
		// (get) Token: 0x0600AC89 RID: 44169 RVA: 0x002B0ECC File Offset: 0x002AF0CC
		// (set) Token: 0x0600AC8A RID: 44170 RVA: 0x00054DDC File Offset: 0x00052FDC
		public unsafe Clickable Clickable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StirringRod.NativeFieldInfoPtr_Clickable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Clickable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StirringRod.NativeFieldInfoPtr_Clickable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700356A RID: 13674
		// (get) Token: 0x0600AC8B RID: 44171 RVA: 0x002B0EFC File Offset: 0x002AF0FC
		// (set) Token: 0x0600AC8C RID: 44172 RVA: 0x00054DFB File Offset: 0x00052FFB
		public unsafe Transform PlaneNormal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StirringRod.NativeFieldInfoPtr_PlaneNormal);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StirringRod.NativeFieldInfoPtr_PlaneNormal), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700356B RID: 13675
		// (get) Token: 0x0600AC8D RID: 44173 RVA: 0x002B0F2C File Offset: 0x002AF12C
		// (set) Token: 0x0600AC8E RID: 44174 RVA: 0x00054E1A File Offset: 0x0005301A
		public unsafe Transform Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StirringRod.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StirringRod.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700356C RID: 13676
		// (get) Token: 0x0600AC8F RID: 44175 RVA: 0x002B0F5C File Offset: 0x002AF15C
		// (set) Token: 0x0600AC90 RID: 44176 RVA: 0x00054E39 File Offset: 0x00053039
		public unsafe Transform RodPivot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StirringRod.NativeFieldInfoPtr_RodPivot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StirringRod.NativeFieldInfoPtr_RodPivot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700356D RID: 13677
		// (get) Token: 0x0600AC91 RID: 44177 RVA: 0x002B0F8C File Offset: 0x002AF18C
		// (set) Token: 0x0600AC92 RID: 44178 RVA: 0x00054E58 File Offset: 0x00053058
		public unsafe AudioSourceController StirSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StirringRod.NativeFieldInfoPtr_StirSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StirringRod.NativeFieldInfoPtr_StirSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700356E RID: 13678
		// (get) Token: 0x0600AC93 RID: 44179 RVA: 0x002B0FBC File Offset: 0x002AF1BC
		// (set) Token: 0x0600AC94 RID: 44180 RVA: 0x00054E77 File Offset: 0x00053077
		public unsafe Vector3 clickOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StirringRod.NativeFieldInfoPtr_clickOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StirringRod.NativeFieldInfoPtr_clickOffset)) = value;
			}
		}

		// Token: 0x1700356F RID: 13679
		// (get) Token: 0x0600AC95 RID: 44181 RVA: 0x002B0FE4 File Offset: 0x002AF1E4
		// (set) Token: 0x0600AC96 RID: 44182 RVA: 0x00054E92 File Offset: 0x00053092
		public unsafe bool isMoving
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StirringRod.NativeFieldInfoPtr_isMoving);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StirringRod.NativeFieldInfoPtr_isMoving)) = value;
			}
		}

		// Token: 0x040073EC RID: 29676
		private static readonly IntPtr NativeFieldInfoPtr_MAX_STIR_RATE;

		// Token: 0x040073ED RID: 29677
		private static readonly IntPtr NativeFieldInfoPtr_MAX_PIVOT_ANGLE;

		// Token: 0x040073EE RID: 29678
		private static readonly IntPtr NativeFieldInfoPtr__Interactable_k__BackingField;

		// Token: 0x040073EF RID: 29679
		private static readonly IntPtr NativeFieldInfoPtr__CurrentStirringSpeed_k__BackingField;

		// Token: 0x040073F0 RID: 29680
		private static readonly IntPtr NativeFieldInfoPtr_LerpSpeed;

		// Token: 0x040073F1 RID: 29681
		private static readonly IntPtr NativeFieldInfoPtr_Clickable;

		// Token: 0x040073F2 RID: 29682
		private static readonly IntPtr NativeFieldInfoPtr_PlaneNormal;

		// Token: 0x040073F3 RID: 29683
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x040073F4 RID: 29684
		private static readonly IntPtr NativeFieldInfoPtr_RodPivot;

		// Token: 0x040073F5 RID: 29685
		private static readonly IntPtr NativeFieldInfoPtr_StirSound;

		// Token: 0x040073F6 RID: 29686
		private static readonly IntPtr NativeFieldInfoPtr_clickOffset;

		// Token: 0x040073F7 RID: 29687
		private static readonly IntPtr NativeFieldInfoPtr_isMoving;

		// Token: 0x040073F8 RID: 29688
		private static readonly IntPtr NativeMethodInfoPtr_get_Interactable_Public_get_Boolean_0;

		// Token: 0x040073F9 RID: 29689
		private static readonly IntPtr NativeMethodInfoPtr_set_Interactable_Private_set_Void_Boolean_0;

		// Token: 0x040073FA RID: 29690
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentStirringSpeed_Public_get_Single_0;

		// Token: 0x040073FB RID: 29691
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentStirringSpeed_Private_set_Void_Single_0;

		// Token: 0x040073FC RID: 29692
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040073FD RID: 29693
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040073FE RID: 29694
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x040073FF RID: 29695
		private static readonly IntPtr NativeMethodInfoPtr_SetInteractable_Public_Void_Boolean_0;

		// Token: 0x04007400 RID: 29696
		private static readonly IntPtr NativeMethodInfoPtr_ClickStart_Public_Void_RaycastHit_0;

		// Token: 0x04007401 RID: 29697
		private static readonly IntPtr NativeMethodInfoPtr_GetPlaneHit_Private_Vector3_0;

		// Token: 0x04007402 RID: 29698
		private static readonly IntPtr NativeMethodInfoPtr_ClickEnd_Public_Void_0;

		// Token: 0x04007403 RID: 29699
		private static readonly IntPtr NativeMethodInfoPtr_Destroy_Public_Void_0;

		// Token: 0x04007404 RID: 29700
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
