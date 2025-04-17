using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppSystem;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Casino
{
	// Token: 0x020004A8 RID: 1192
	public class SlotReel : MonoBehaviour
	{
		// Token: 0x060068B1 RID: 26801 RVA: 0x001D613C File Offset: 0x001D433C
		// Note: this type is marked as 'beforefieldinit'.
		static SlotReel()
		{
			Il2CppClassPointerStore<SlotReel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Casino", "SlotReel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SlotReel>.NativeClassPtr);
			SlotReel.NativeFieldInfoPtr__IsSpinning_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotReel>.NativeClassPtr, "<IsSpinning>k__BackingField");
			SlotReel.NativeFieldInfoPtr__CurrentSymbol_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotReel>.NativeClassPtr, "<CurrentSymbol>k__BackingField");
			SlotReel.NativeFieldInfoPtr__CurrentRotation_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotReel>.NativeClassPtr, "<CurrentRotation>k__BackingField");
			SlotReel.NativeFieldInfoPtr_SymbolRotations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotReel>.NativeClassPtr, "SymbolRotations");
			SlotReel.NativeFieldInfoPtr_SpinSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotReel>.NativeClassPtr, "SpinSpeed");
			SlotReel.NativeFieldInfoPtr_StopSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotReel>.NativeClassPtr, "StopSound");
			SlotReel.NativeFieldInfoPtr_onStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotReel>.NativeClassPtr, "onStart");
			SlotReel.NativeFieldInfoPtr_onStop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotReel>.NativeClassPtr, "onStop");
			SlotReel.NativeMethodInfoPtr_get_IsSpinning_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotReel>.NativeClassPtr, 100676628);
			SlotReel.NativeMethodInfoPtr_set_IsSpinning_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotReel>.NativeClassPtr, 100676629);
			SlotReel.NativeMethodInfoPtr_get_CurrentSymbol_Public_get_ESymbol_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotReel>.NativeClassPtr, 100676630);
			SlotReel.NativeMethodInfoPtr_set_CurrentSymbol_Private_set_Void_ESymbol_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotReel>.NativeClassPtr, 100676631);
			SlotReel.NativeMethodInfoPtr_get_CurrentRotation_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotReel>.NativeClassPtr, 100676632);
			SlotReel.NativeMethodInfoPtr_set_CurrentRotation_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotReel>.NativeClassPtr, 100676633);
			SlotReel.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotReel>.NativeClassPtr, 100676634);
			SlotReel.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotReel>.NativeClassPtr, 100676635);
			SlotReel.NativeMethodInfoPtr_Spin_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotReel>.NativeClassPtr, 100676636);
			SlotReel.NativeMethodInfoPtr_Stop_Public_Void_ESymbol_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotReel>.NativeClassPtr, 100676637);
			SlotReel.NativeMethodInfoPtr_SetSymbol_Public_Void_ESymbol_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotReel>.NativeClassPtr, 100676638);
			SlotReel.NativeMethodInfoPtr_SetReelRotation_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotReel>.NativeClassPtr, 100676639);
			SlotReel.NativeMethodInfoPtr_GetSymbolRotation_Private_Single_ESymbol_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotReel>.NativeClassPtr, 100676640);
			SlotReel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotReel>.NativeClassPtr, 100676641);
		}

		// Token: 0x17001F73 RID: 8051
		// (get) Token: 0x060068B2 RID: 26802 RVA: 0x001D6324 File Offset: 0x001D4524
		// (set) Token: 0x060068B3 RID: 26803 RVA: 0x001D6360 File Offset: 0x001D4560
		public unsafe bool IsSpinning
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 35361, RefRangeEnd = 35362, XrefRangeStart = 35361, XrefRangeEnd = 35362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotReel.NativeMethodInfoPtr_get_IsSpinning_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotReel.NativeMethodInfoPtr_set_IsSpinning_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001F74 RID: 8052
		// (get) Token: 0x060068B4 RID: 26804 RVA: 0x001D63A0 File Offset: 0x001D45A0
		// (set) Token: 0x060068B5 RID: 26805 RVA: 0x001D63DC File Offset: 0x001D45DC
		public unsafe SlotMachine.ESymbol CurrentSymbol
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotReel.NativeMethodInfoPtr_get_CurrentSymbol_Public_get_ESymbol_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 29962, RefRangeEnd = 29963, XrefRangeStart = 29962, XrefRangeEnd = 29963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotReel.NativeMethodInfoPtr_set_CurrentSymbol_Private_set_Void_ESymbol_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001F75 RID: 8053
		// (get) Token: 0x060068B6 RID: 26806 RVA: 0x001D641C File Offset: 0x001D461C
		// (set) Token: 0x060068B7 RID: 26807 RVA: 0x001D6458 File Offset: 0x001D4658
		public unsafe float CurrentRotation
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 59847, RefRangeEnd = 59848, XrefRangeStart = 59847, XrefRangeEnd = 59848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotReel.NativeMethodInfoPtr_get_CurrentRotation_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotReel.NativeMethodInfoPtr_set_CurrentRotation_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060068B8 RID: 26808 RVA: 0x001D6498 File Offset: 0x001D4698
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211885, XrefRangeEnd = 211889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotReel.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060068B9 RID: 26809 RVA: 0x001D64CC File Offset: 0x001D46CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211889, XrefRangeEnd = 211906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotReel.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060068BA RID: 26810 RVA: 0x001D6500 File Offset: 0x001D4700
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211906, XrefRangeEnd = 211907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Spin()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotReel.NativeMethodInfoPtr_Spin_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060068BB RID: 26811 RVA: 0x001D6534 File Offset: 0x001D4734
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211907, XrefRangeEnd = 211908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Stop(SlotMachine.ESymbol endSymbol)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref endSymbol;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotReel.NativeMethodInfoPtr_Stop_Public_Void_ESymbol_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060068BC RID: 26812 RVA: 0x001D6574 File Offset: 0x001D4774
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 29962, RefRangeEnd = 29963, XrefRangeStart = 29962, XrefRangeEnd = 29963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSymbol(SlotMachine.ESymbol symbol)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref symbol;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotReel.NativeMethodInfoPtr_SetSymbol_Public_Void_ESymbol_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060068BD RID: 26813 RVA: 0x001D65B4 File Offset: 0x001D47B4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 211912, RefRangeEnd = 211914, XrefRangeStart = 211908, XrefRangeEnd = 211912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetReelRotation(float rotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref rotation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotReel.NativeMethodInfoPtr_SetReelRotation_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060068BE RID: 26814 RVA: 0x001D65F4 File Offset: 0x001D47F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211914, XrefRangeEnd = 211918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetSymbolRotation(SlotMachine.ESymbol symbol)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref symbol;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotReel.NativeMethodInfoPtr_GetSymbolRotation_Private_Single_ESymbol_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060068BF RID: 26815 RVA: 0x001D6640 File Offset: 0x001D4840
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 211918, XrefRangeEnd = 211919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SlotReel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SlotReel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotReel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060068C0 RID: 26816 RVA: 0x00031586 File Offset: 0x0002F786
		public SlotReel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001F6B RID: 8043
		// (get) Token: 0x060068C1 RID: 26817 RVA: 0x001D667C File Offset: 0x001D487C
		// (set) Token: 0x060068C2 RID: 26818 RVA: 0x0003158F File Offset: 0x0002F78F
		public unsafe bool _IsSpinning_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotReel.NativeFieldInfoPtr__IsSpinning_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotReel.NativeFieldInfoPtr__IsSpinning_k__BackingField)) = value;
			}
		}

		// Token: 0x17001F6C RID: 8044
		// (get) Token: 0x060068C3 RID: 26819 RVA: 0x001D66A4 File Offset: 0x001D48A4
		// (set) Token: 0x060068C4 RID: 26820 RVA: 0x000315AA File Offset: 0x0002F7AA
		public unsafe SlotMachine.ESymbol _CurrentSymbol_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotReel.NativeFieldInfoPtr__CurrentSymbol_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotReel.NativeFieldInfoPtr__CurrentSymbol_k__BackingField)) = value;
			}
		}

		// Token: 0x17001F6D RID: 8045
		// (get) Token: 0x060068C5 RID: 26821 RVA: 0x001D66CC File Offset: 0x001D48CC
		// (set) Token: 0x060068C6 RID: 26822 RVA: 0x000315C5 File Offset: 0x0002F7C5
		public unsafe float _CurrentRotation_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotReel.NativeFieldInfoPtr__CurrentRotation_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotReel.NativeFieldInfoPtr__CurrentRotation_k__BackingField)) = value;
			}
		}

		// Token: 0x17001F6E RID: 8046
		// (get) Token: 0x060068C7 RID: 26823 RVA: 0x001D66F4 File Offset: 0x001D48F4
		// (set) Token: 0x060068C8 RID: 26824 RVA: 0x000315E0 File Offset: 0x0002F7E0
		public unsafe Il2CppReferenceArray<SlotReel.SymbolRotation> SymbolRotations
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotReel.NativeFieldInfoPtr_SymbolRotations);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SlotReel.SymbolRotation>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotReel.NativeFieldInfoPtr_SymbolRotations), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F6F RID: 8047
		// (get) Token: 0x060068C9 RID: 26825 RVA: 0x001D6724 File Offset: 0x001D4924
		// (set) Token: 0x060068CA RID: 26826 RVA: 0x000315FF File Offset: 0x0002F7FF
		public unsafe float SpinSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotReel.NativeFieldInfoPtr_SpinSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotReel.NativeFieldInfoPtr_SpinSpeed)) = value;
			}
		}

		// Token: 0x17001F70 RID: 8048
		// (get) Token: 0x060068CB RID: 26827 RVA: 0x001D674C File Offset: 0x001D494C
		// (set) Token: 0x060068CC RID: 26828 RVA: 0x0003161A File Offset: 0x0002F81A
		public unsafe AudioSourceController StopSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotReel.NativeFieldInfoPtr_StopSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotReel.NativeFieldInfoPtr_StopSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F71 RID: 8049
		// (get) Token: 0x060068CD RID: 26829 RVA: 0x001D677C File Offset: 0x001D497C
		// (set) Token: 0x060068CE RID: 26830 RVA: 0x00031639 File Offset: 0x0002F839
		public unsafe UnityEvent onStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotReel.NativeFieldInfoPtr_onStart);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotReel.NativeFieldInfoPtr_onStart), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F72 RID: 8050
		// (get) Token: 0x060068CF RID: 26831 RVA: 0x001D67AC File Offset: 0x001D49AC
		// (set) Token: 0x060068D0 RID: 26832 RVA: 0x00031658 File Offset: 0x0002F858
		public unsafe UnityEvent onStop
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotReel.NativeFieldInfoPtr_onStop);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotReel.NativeFieldInfoPtr_onStop), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040047C6 RID: 18374
		private static readonly IntPtr NativeFieldInfoPtr__IsSpinning_k__BackingField;

		// Token: 0x040047C7 RID: 18375
		private static readonly IntPtr NativeFieldInfoPtr__CurrentSymbol_k__BackingField;

		// Token: 0x040047C8 RID: 18376
		private static readonly IntPtr NativeFieldInfoPtr__CurrentRotation_k__BackingField;

		// Token: 0x040047C9 RID: 18377
		private static readonly IntPtr NativeFieldInfoPtr_SymbolRotations;

		// Token: 0x040047CA RID: 18378
		private static readonly IntPtr NativeFieldInfoPtr_SpinSpeed;

		// Token: 0x040047CB RID: 18379
		private static readonly IntPtr NativeFieldInfoPtr_StopSound;

		// Token: 0x040047CC RID: 18380
		private static readonly IntPtr NativeFieldInfoPtr_onStart;

		// Token: 0x040047CD RID: 18381
		private static readonly IntPtr NativeFieldInfoPtr_onStop;

		// Token: 0x040047CE RID: 18382
		private static readonly IntPtr NativeMethodInfoPtr_get_IsSpinning_Public_get_Boolean_0;

		// Token: 0x040047CF RID: 18383
		private static readonly IntPtr NativeMethodInfoPtr_set_IsSpinning_Private_set_Void_Boolean_0;

		// Token: 0x040047D0 RID: 18384
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentSymbol_Public_get_ESymbol_0;

		// Token: 0x040047D1 RID: 18385
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentSymbol_Private_set_Void_ESymbol_0;

		// Token: 0x040047D2 RID: 18386
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentRotation_Public_get_Single_0;

		// Token: 0x040047D3 RID: 18387
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentRotation_Private_set_Void_Single_0;

		// Token: 0x040047D4 RID: 18388
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040047D5 RID: 18389
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040047D6 RID: 18390
		private static readonly IntPtr NativeMethodInfoPtr_Spin_Public_Void_0;

		// Token: 0x040047D7 RID: 18391
		private static readonly IntPtr NativeMethodInfoPtr_Stop_Public_Void_ESymbol_0;

		// Token: 0x040047D8 RID: 18392
		private static readonly IntPtr NativeMethodInfoPtr_SetSymbol_Public_Void_ESymbol_0;

		// Token: 0x040047D9 RID: 18393
		private static readonly IntPtr NativeMethodInfoPtr_SetReelRotation_Private_Void_Single_0;

		// Token: 0x040047DA RID: 18394
		private static readonly IntPtr NativeMethodInfoPtr_GetSymbolRotation_Private_Single_ESymbol_0;

		// Token: 0x040047DB RID: 18395
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000A4E RID: 2638
		[Serializable]
		public class SymbolRotation : Il2CppSystem.Object
		{
			// Token: 0x0600D01E RID: 53278 RVA: 0x0031F004 File Offset: 0x0031D204
			// Note: this type is marked as 'beforefieldinit'.
			static SymbolRotation()
			{
				Il2CppClassPointerStore<SlotReel.SymbolRotation>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SlotReel>.NativeClassPtr, "SymbolRotation");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SlotReel.SymbolRotation>.NativeClassPtr);
				SlotReel.SymbolRotation.NativeFieldInfoPtr_Symbol = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotReel.SymbolRotation>.NativeClassPtr, "Symbol");
				SlotReel.SymbolRotation.NativeFieldInfoPtr_Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotReel.SymbolRotation>.NativeClassPtr, "Rotation");
				SlotReel.SymbolRotation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotReel.SymbolRotation>.NativeClassPtr, 100676642);
			}

			// Token: 0x0600D01F RID: 53279 RVA: 0x0031F06C File Offset: 0x0031D26C
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SymbolRotation() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SlotReel.SymbolRotation>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotReel.SymbolRotation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D020 RID: 53280 RVA: 0x0006546E File Offset: 0x0006366E
			public SymbolRotation(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170040A4 RID: 16548
			// (get) Token: 0x0600D021 RID: 53281 RVA: 0x0031F0A8 File Offset: 0x0031D2A8
			// (set) Token: 0x0600D022 RID: 53282 RVA: 0x00065477 File Offset: 0x00063677
			public unsafe SlotMachine.ESymbol Symbol
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotReel.SymbolRotation.NativeFieldInfoPtr_Symbol);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotReel.SymbolRotation.NativeFieldInfoPtr_Symbol)) = value;
				}
			}

			// Token: 0x170040A5 RID: 16549
			// (get) Token: 0x0600D023 RID: 53283 RVA: 0x0031F0D0 File Offset: 0x0031D2D0
			// (set) Token: 0x0600D024 RID: 53284 RVA: 0x00065492 File Offset: 0x00063692
			public unsafe float Rotation
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotReel.SymbolRotation.NativeFieldInfoPtr_Rotation);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SlotReel.SymbolRotation.NativeFieldInfoPtr_Rotation)) = value;
				}
			}

			// Token: 0x04008C78 RID: 35960
			private static readonly IntPtr NativeFieldInfoPtr_Symbol;

			// Token: 0x04008C79 RID: 35961
			private static readonly IntPtr NativeFieldInfoPtr_Rotation;

			// Token: 0x04008C7A RID: 35962
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
