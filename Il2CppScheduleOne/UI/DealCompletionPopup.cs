using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Economy;
using Il2CppScheduleOne.Quests;
using Il2CppScheduleOne.UI.Relations;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000630 RID: 1584
	public class DealCompletionPopup : Singleton<DealCompletionPopup>
	{
		// Token: 0x06008BEA RID: 35818 RVA: 0x00249178 File Offset: 0x00247378
		// Note: this type is marked as 'beforefieldinit'.
		static DealCompletionPopup()
		{
			Il2CppClassPointerStore<DealCompletionPopup>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "DealCompletionPopup");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DealCompletionPopup>.NativeClassPtr);
			DealCompletionPopup.NativeFieldInfoPtr__IsPlaying_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealCompletionPopup>.NativeClassPtr, "<IsPlaying>k__BackingField");
			DealCompletionPopup.NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealCompletionPopup>.NativeClassPtr, "Canvas");
			DealCompletionPopup.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealCompletionPopup>.NativeClassPtr, "Container");
			DealCompletionPopup.NativeFieldInfoPtr_Group = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealCompletionPopup>.NativeClassPtr, "Group");
			DealCompletionPopup.NativeFieldInfoPtr_Anim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealCompletionPopup>.NativeClassPtr, "Anim");
			DealCompletionPopup.NativeFieldInfoPtr_Title = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealCompletionPopup>.NativeClassPtr, "Title");
			DealCompletionPopup.NativeFieldInfoPtr_PaymentLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealCompletionPopup>.NativeClassPtr, "PaymentLabel");
			DealCompletionPopup.NativeFieldInfoPtr_SatisfactionValueLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealCompletionPopup>.NativeClassPtr, "SatisfactionValueLabel");
			DealCompletionPopup.NativeFieldInfoPtr_RelationCircle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealCompletionPopup>.NativeClassPtr, "RelationCircle");
			DealCompletionPopup.NativeFieldInfoPtr_RelationshipLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealCompletionPopup>.NativeClassPtr, "RelationshipLabel");
			DealCompletionPopup.NativeFieldInfoPtr_SatisfactionGradient = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealCompletionPopup>.NativeClassPtr, "SatisfactionGradient");
			DealCompletionPopup.NativeFieldInfoPtr_SoundEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealCompletionPopup>.NativeClassPtr, "SoundEffect");
			DealCompletionPopup.NativeFieldInfoPtr_BonusLabels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealCompletionPopup>.NativeClassPtr, "BonusLabels");
			DealCompletionPopup.NativeFieldInfoPtr_routine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealCompletionPopup>.NativeClassPtr, "routine");
			DealCompletionPopup.NativeMethodInfoPtr_get_IsPlaying_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealCompletionPopup>.NativeClassPtr, 100680680);
			DealCompletionPopup.NativeMethodInfoPtr_set_IsPlaying_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealCompletionPopup>.NativeClassPtr, 100680681);
			DealCompletionPopup.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealCompletionPopup>.NativeClassPtr, 100680682);
			DealCompletionPopup.NativeMethodInfoPtr_PlayPopup_Public_Void_Customer_Single_Single_Single_List_1_BonusPayment_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealCompletionPopup>.NativeClassPtr, 100680683);
			DealCompletionPopup.NativeMethodInfoPtr_SetRelationshipLabel_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealCompletionPopup>.NativeClassPtr, 100680684);
			DealCompletionPopup.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealCompletionPopup>.NativeClassPtr, 100680685);
		}

		// Token: 0x17002AB7 RID: 10935
		// (get) Token: 0x06008BEB RID: 35819 RVA: 0x00249338 File Offset: 0x00247538
		// (set) Token: 0x06008BEC RID: 35820 RVA: 0x00249374 File Offset: 0x00247574
		public unsafe bool IsPlaying
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealCompletionPopup.NativeMethodInfoPtr_get_IsPlaying_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 37988, RefRangeEnd = 38011, XrefRangeStart = 37988, XrefRangeEnd = 38011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealCompletionPopup.NativeMethodInfoPtr_set_IsPlaying_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06008BED RID: 35821 RVA: 0x002493B4 File Offset: 0x002475B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256080, XrefRangeEnd = 256087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DealCompletionPopup.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008BEE RID: 35822 RVA: 0x002493F0 File Offset: 0x002475F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 256103, RefRangeEnd = 256104, XrefRangeStart = 256087, XrefRangeEnd = 256103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayPopup(Customer customer, float satisfaction, float originalRelationshipDelta, float basePayment, List<Contract.BonusPayment> bonuses)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(customer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref satisfaction;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref originalRelationshipDelta;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref basePayment;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(bonuses);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealCompletionPopup.NativeMethodInfoPtr_PlayPopup_Public_Void_Customer_Single_Single_Single_List_1_BonusPayment_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008BEF RID: 35823 RVA: 0x00249470 File Offset: 0x00247670
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 256112, RefRangeEnd = 256115, XrefRangeStart = 256104, XrefRangeEnd = 256112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetRelationshipLabel(float delta)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref delta;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealCompletionPopup.NativeMethodInfoPtr_SetRelationshipLabel_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008BF0 RID: 35824 RVA: 0x002494B0 File Offset: 0x002476B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256115, XrefRangeEnd = 256118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DealCompletionPopup() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DealCompletionPopup>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealCompletionPopup.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008BF1 RID: 35825 RVA: 0x00043005 File Offset: 0x00041205
		public DealCompletionPopup(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002AA9 RID: 10921
		// (get) Token: 0x06008BF2 RID: 35826 RVA: 0x002494EC File Offset: 0x002476EC
		// (set) Token: 0x06008BF3 RID: 35827 RVA: 0x0004300E File Offset: 0x0004120E
		public unsafe bool _IsPlaying_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.NativeFieldInfoPtr__IsPlaying_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.NativeFieldInfoPtr__IsPlaying_k__BackingField)) = value;
			}
		}

		// Token: 0x17002AAA RID: 10922
		// (get) Token: 0x06008BF4 RID: 35828 RVA: 0x00249514 File Offset: 0x00247714
		// (set) Token: 0x06008BF5 RID: 35829 RVA: 0x00043029 File Offset: 0x00041229
		public unsafe Canvas Canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.NativeFieldInfoPtr_Canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.NativeFieldInfoPtr_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002AAB RID: 10923
		// (get) Token: 0x06008BF6 RID: 35830 RVA: 0x00249544 File Offset: 0x00247744
		// (set) Token: 0x06008BF7 RID: 35831 RVA: 0x00043048 File Offset: 0x00041248
		public unsafe RectTransform Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002AAC RID: 10924
		// (get) Token: 0x06008BF8 RID: 35832 RVA: 0x00249574 File Offset: 0x00247774
		// (set) Token: 0x06008BF9 RID: 35833 RVA: 0x00043067 File Offset: 0x00041267
		public unsafe CanvasGroup Group
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.NativeFieldInfoPtr_Group);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.NativeFieldInfoPtr_Group), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002AAD RID: 10925
		// (get) Token: 0x06008BFA RID: 35834 RVA: 0x002495A4 File Offset: 0x002477A4
		// (set) Token: 0x06008BFB RID: 35835 RVA: 0x00043086 File Offset: 0x00041286
		public unsafe Animation Anim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.NativeFieldInfoPtr_Anim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.NativeFieldInfoPtr_Anim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002AAE RID: 10926
		// (get) Token: 0x06008BFC RID: 35836 RVA: 0x002495D4 File Offset: 0x002477D4
		// (set) Token: 0x06008BFD RID: 35837 RVA: 0x000430A5 File Offset: 0x000412A5
		public unsafe TextMeshProUGUI Title
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.NativeFieldInfoPtr_Title);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.NativeFieldInfoPtr_Title), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002AAF RID: 10927
		// (get) Token: 0x06008BFE RID: 35838 RVA: 0x00249604 File Offset: 0x00247804
		// (set) Token: 0x06008BFF RID: 35839 RVA: 0x000430C4 File Offset: 0x000412C4
		public unsafe TextMeshProUGUI PaymentLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.NativeFieldInfoPtr_PaymentLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.NativeFieldInfoPtr_PaymentLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002AB0 RID: 10928
		// (get) Token: 0x06008C00 RID: 35840 RVA: 0x00249634 File Offset: 0x00247834
		// (set) Token: 0x06008C01 RID: 35841 RVA: 0x000430E3 File Offset: 0x000412E3
		public unsafe TextMeshProUGUI SatisfactionValueLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.NativeFieldInfoPtr_SatisfactionValueLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.NativeFieldInfoPtr_SatisfactionValueLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002AB1 RID: 10929
		// (get) Token: 0x06008C02 RID: 35842 RVA: 0x00249664 File Offset: 0x00247864
		// (set) Token: 0x06008C03 RID: 35843 RVA: 0x00043102 File Offset: 0x00041302
		public unsafe RelationCircle RelationCircle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.NativeFieldInfoPtr_RelationCircle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RelationCircle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.NativeFieldInfoPtr_RelationCircle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002AB2 RID: 10930
		// (get) Token: 0x06008C04 RID: 35844 RVA: 0x00249694 File Offset: 0x00247894
		// (set) Token: 0x06008C05 RID: 35845 RVA: 0x00043121 File Offset: 0x00041321
		public unsafe TextMeshProUGUI RelationshipLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.NativeFieldInfoPtr_RelationshipLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.NativeFieldInfoPtr_RelationshipLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002AB3 RID: 10931
		// (get) Token: 0x06008C06 RID: 35846 RVA: 0x002496C4 File Offset: 0x002478C4
		// (set) Token: 0x06008C07 RID: 35847 RVA: 0x00043140 File Offset: 0x00041340
		public unsafe Gradient SatisfactionGradient
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.NativeFieldInfoPtr_SatisfactionGradient);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Gradient>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.NativeFieldInfoPtr_SatisfactionGradient), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002AB4 RID: 10932
		// (get) Token: 0x06008C08 RID: 35848 RVA: 0x002496F4 File Offset: 0x002478F4
		// (set) Token: 0x06008C09 RID: 35849 RVA: 0x0004315F File Offset: 0x0004135F
		public unsafe AudioSourceController SoundEffect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.NativeFieldInfoPtr_SoundEffect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.NativeFieldInfoPtr_SoundEffect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002AB5 RID: 10933
		// (get) Token: 0x06008C0A RID: 35850 RVA: 0x00249724 File Offset: 0x00247924
		// (set) Token: 0x06008C0B RID: 35851 RVA: 0x0004317E File Offset: 0x0004137E
		public unsafe Il2CppReferenceArray<TextMeshProUGUI> BonusLabels
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.NativeFieldInfoPtr_BonusLabels);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TextMeshProUGUI>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.NativeFieldInfoPtr_BonusLabels), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002AB6 RID: 10934
		// (get) Token: 0x06008C0C RID: 35852 RVA: 0x00249754 File Offset: 0x00247954
		// (set) Token: 0x06008C0D RID: 35853 RVA: 0x0004319D File Offset: 0x0004139D
		public unsafe Coroutine routine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.NativeFieldInfoPtr_routine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.NativeFieldInfoPtr_routine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005EDF RID: 24287
		private static readonly IntPtr NativeFieldInfoPtr__IsPlaying_k__BackingField;

		// Token: 0x04005EE0 RID: 24288
		private static readonly IntPtr NativeFieldInfoPtr_Canvas;

		// Token: 0x04005EE1 RID: 24289
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x04005EE2 RID: 24290
		private static readonly IntPtr NativeFieldInfoPtr_Group;

		// Token: 0x04005EE3 RID: 24291
		private static readonly IntPtr NativeFieldInfoPtr_Anim;

		// Token: 0x04005EE4 RID: 24292
		private static readonly IntPtr NativeFieldInfoPtr_Title;

		// Token: 0x04005EE5 RID: 24293
		private static readonly IntPtr NativeFieldInfoPtr_PaymentLabel;

		// Token: 0x04005EE6 RID: 24294
		private static readonly IntPtr NativeFieldInfoPtr_SatisfactionValueLabel;

		// Token: 0x04005EE7 RID: 24295
		private static readonly IntPtr NativeFieldInfoPtr_RelationCircle;

		// Token: 0x04005EE8 RID: 24296
		private static readonly IntPtr NativeFieldInfoPtr_RelationshipLabel;

		// Token: 0x04005EE9 RID: 24297
		private static readonly IntPtr NativeFieldInfoPtr_SatisfactionGradient;

		// Token: 0x04005EEA RID: 24298
		private static readonly IntPtr NativeFieldInfoPtr_SoundEffect;

		// Token: 0x04005EEB RID: 24299
		private static readonly IntPtr NativeFieldInfoPtr_BonusLabels;

		// Token: 0x04005EEC RID: 24300
		private static readonly IntPtr NativeFieldInfoPtr_routine;

		// Token: 0x04005EED RID: 24301
		private static readonly IntPtr NativeMethodInfoPtr_get_IsPlaying_Public_get_Boolean_0;

		// Token: 0x04005EEE RID: 24302
		private static readonly IntPtr NativeMethodInfoPtr_set_IsPlaying_Protected_set_Void_Boolean_0;

		// Token: 0x04005EEF RID: 24303
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04005EF0 RID: 24304
		private static readonly IntPtr NativeMethodInfoPtr_PlayPopup_Public_Void_Customer_Single_Single_Single_List_1_BonusPayment_0;

		// Token: 0x04005EF1 RID: 24305
		private static readonly IntPtr NativeMethodInfoPtr_SetRelationshipLabel_Private_Void_Single_0;

		// Token: 0x04005EF2 RID: 24306
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B19 RID: 2841
		[ObfuscatedName("ScheduleOne.UI.DealCompletionPopup+<>c__DisplayClass18_0")]
		public sealed class __c__DisplayClass18_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D6E7 RID: 55015 RVA: 0x00332120 File Offset: 0x00330320
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass18_0()
			{
				Il2CppClassPointerStore<DealCompletionPopup.__c__DisplayClass18_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DealCompletionPopup>.NativeClassPtr, "<>c__DisplayClass18_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DealCompletionPopup.__c__DisplayClass18_0>.NativeClassPtr);
				DealCompletionPopup.__c__DisplayClass18_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealCompletionPopup.__c__DisplayClass18_0>.NativeClassPtr, "<>4__this");
				DealCompletionPopup.__c__DisplayClass18_0.NativeFieldInfoPtr_customer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealCompletionPopup.__c__DisplayClass18_0>.NativeClassPtr, "customer");
				DealCompletionPopup.__c__DisplayClass18_0.NativeFieldInfoPtr_bonuses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealCompletionPopup.__c__DisplayClass18_0>.NativeClassPtr, "bonuses");
				DealCompletionPopup.__c__DisplayClass18_0.NativeFieldInfoPtr_originalRelationshipDelta = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealCompletionPopup.__c__DisplayClass18_0>.NativeClassPtr, "originalRelationshipDelta");
				DealCompletionPopup.__c__DisplayClass18_0.NativeFieldInfoPtr_basePayment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealCompletionPopup.__c__DisplayClass18_0>.NativeClassPtr, "basePayment");
				DealCompletionPopup.__c__DisplayClass18_0.NativeFieldInfoPtr_satisfaction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealCompletionPopup.__c__DisplayClass18_0>.NativeClassPtr, "satisfaction");
				DealCompletionPopup.__c__DisplayClass18_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealCompletionPopup.__c__DisplayClass18_0>.NativeClassPtr, 100680686);
				DealCompletionPopup.__c__DisplayClass18_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealCompletionPopup.__c__DisplayClass18_0>.NativeClassPtr, 100680687);
				DealCompletionPopup.__c__DisplayClass18_0.NativeMethodInfoPtr__PlayPopup_b__1_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealCompletionPopup.__c__DisplayClass18_0>.NativeClassPtr, 100680688);
			}

			// Token: 0x0600D6E8 RID: 55016 RVA: 0x00332200 File Offset: 0x00330400
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass18_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DealCompletionPopup.__c__DisplayClass18_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealCompletionPopup.__c__DisplayClass18_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D6E9 RID: 55017 RVA: 0x0033223C File Offset: 0x0033043C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256074, XrefRangeEnd = 256079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealCompletionPopup.__c__DisplayClass18_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600D6EA RID: 55018 RVA: 0x0033227C File Offset: 0x0033047C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256079, XrefRangeEnd = 256080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _PlayPopup_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealCompletionPopup.__c__DisplayClass18_0.NativeMethodInfoPtr__PlayPopup_b__1_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D6EB RID: 55019 RVA: 0x00068963 File Offset: 0x00066B63
			public __c__DisplayClass18_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004292 RID: 17042
			// (get) Token: 0x0600D6EC RID: 55020 RVA: 0x003322B8 File Offset: 0x003304B8
			// (set) Token: 0x0600D6ED RID: 55021 RVA: 0x0006896C File Offset: 0x00066B6C
			public unsafe DealCompletionPopup __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.__c__DisplayClass18_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DealCompletionPopup>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.__c__DisplayClass18_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004293 RID: 17043
			// (get) Token: 0x0600D6EE RID: 55022 RVA: 0x003322E8 File Offset: 0x003304E8
			// (set) Token: 0x0600D6EF RID: 55023 RVA: 0x0006898B File Offset: 0x00066B8B
			public unsafe Customer customer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.__c__DisplayClass18_0.NativeFieldInfoPtr_customer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Customer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.__c__DisplayClass18_0.NativeFieldInfoPtr_customer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004294 RID: 17044
			// (get) Token: 0x0600D6F0 RID: 55024 RVA: 0x00332318 File Offset: 0x00330518
			// (set) Token: 0x0600D6F1 RID: 55025 RVA: 0x000689AA File Offset: 0x00066BAA
			public unsafe List<Contract.BonusPayment> bonuses
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.__c__DisplayClass18_0.NativeFieldInfoPtr_bonuses);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Contract.BonusPayment>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.__c__DisplayClass18_0.NativeFieldInfoPtr_bonuses), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004295 RID: 17045
			// (get) Token: 0x0600D6F2 RID: 55026 RVA: 0x00332348 File Offset: 0x00330548
			// (set) Token: 0x0600D6F3 RID: 55027 RVA: 0x000689C9 File Offset: 0x00066BC9
			public unsafe float originalRelationshipDelta
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.__c__DisplayClass18_0.NativeFieldInfoPtr_originalRelationshipDelta);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.__c__DisplayClass18_0.NativeFieldInfoPtr_originalRelationshipDelta)) = value;
				}
			}

			// Token: 0x17004296 RID: 17046
			// (get) Token: 0x0600D6F4 RID: 55028 RVA: 0x00332370 File Offset: 0x00330570
			// (set) Token: 0x0600D6F5 RID: 55029 RVA: 0x000689E4 File Offset: 0x00066BE4
			public unsafe float basePayment
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.__c__DisplayClass18_0.NativeFieldInfoPtr_basePayment);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.__c__DisplayClass18_0.NativeFieldInfoPtr_basePayment)) = value;
				}
			}

			// Token: 0x17004297 RID: 17047
			// (get) Token: 0x0600D6F6 RID: 55030 RVA: 0x00332398 File Offset: 0x00330598
			// (set) Token: 0x0600D6F7 RID: 55031 RVA: 0x000689FF File Offset: 0x00066BFF
			public unsafe float satisfaction
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.__c__DisplayClass18_0.NativeFieldInfoPtr_satisfaction);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.__c__DisplayClass18_0.NativeFieldInfoPtr_satisfaction)) = value;
				}
			}

			// Token: 0x04009081 RID: 36993
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009082 RID: 36994
			private static readonly IntPtr NativeFieldInfoPtr_customer;

			// Token: 0x04009083 RID: 36995
			private static readonly IntPtr NativeFieldInfoPtr_bonuses;

			// Token: 0x04009084 RID: 36996
			private static readonly IntPtr NativeFieldInfoPtr_originalRelationshipDelta;

			// Token: 0x04009085 RID: 36997
			private static readonly IntPtr NativeFieldInfoPtr_basePayment;

			// Token: 0x04009086 RID: 36998
			private static readonly IntPtr NativeFieldInfoPtr_satisfaction;

			// Token: 0x04009087 RID: 36999
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009088 RID: 37000
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x04009089 RID: 37001
			private static readonly IntPtr NativeMethodInfoPtr__PlayPopup_b__1_Internal_Boolean_0;

			// Token: 0x02000C70 RID: 3184
			[ObfuscatedName("ScheduleOne.UI.DealCompletionPopup+<>c__DisplayClass18_0+<<PlayPopup>g__Routine|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E51B RID: 58651 RVA: 0x0035B028 File Offset: 0x00359228
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique()
				{
					Il2CppClassPointerStore<DealCompletionPopup.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DealCompletionPopup.__c__DisplayClass18_0>.NativeClassPtr, "<<PlayPopup>g__Routine|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DealCompletionPopup.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique>.NativeClassPtr);
					DealCompletionPopup.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealCompletionPopup.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique>.NativeClassPtr, "<>1__state");
					DealCompletionPopup.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealCompletionPopup.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique>.NativeClassPtr, "<>2__current");
					DealCompletionPopup.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealCompletionPopup.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique>.NativeClassPtr, "<>4__this");
					DealCompletionPopup.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique.NativeFieldInfoPtr__paymentLerpTime_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealCompletionPopup.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique>.NativeClassPtr, "<paymentLerpTime>5__2");
					DealCompletionPopup.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique.NativeFieldInfoPtr__satisfactionLerpTime_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealCompletionPopup.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique>.NativeClassPtr, "<satisfactionLerpTime>5__3");
					DealCompletionPopup.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique.NativeFieldInfoPtr__endDelta_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealCompletionPopup.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique>.NativeClassPtr, "<endDelta>5__4");
					DealCompletionPopup.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique.NativeFieldInfoPtr__lerpTime_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealCompletionPopup.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique>.NativeClassPtr, "<lerpTime>5__5");
					DealCompletionPopup.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique.NativeFieldInfoPtr__i_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealCompletionPopup.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique>.NativeClassPtr, "<i>5__6");
					DealCompletionPopup.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealCompletionPopup.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique>.NativeClassPtr, 100680689);
					DealCompletionPopup.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealCompletionPopup.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique>.NativeClassPtr, 100680690);
					DealCompletionPopup.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealCompletionPopup.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique>.NativeClassPtr, 100680691);
					DealCompletionPopup.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealCompletionPopup.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique>.NativeClassPtr, 100680692);
					DealCompletionPopup.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealCompletionPopup.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique>.NativeClassPtr, 100680693);
					DealCompletionPopup.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealCompletionPopup.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique>.NativeClassPtr, 100680694);
				}

				// Token: 0x0600E51C RID: 58652 RVA: 0x0035B16C File Offset: 0x0035936C
				[CallerCount(61)]
				[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DealCompletionPopup.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealCompletionPopup.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E51D RID: 58653 RVA: 0x0035B1B4 File Offset: 0x003593B4
				[CallerCount(13604)]
				[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealCompletionPopup.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E51E RID: 58654 RVA: 0x0035B1E8 File Offset: 0x003593E8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255954, XrefRangeEnd = 256069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealCompletionPopup.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x1700473D RID: 18237
				// (get) Token: 0x0600E51F RID: 58655 RVA: 0x0035B224 File Offset: 0x00359424
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealCompletionPopup.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E520 RID: 58656 RVA: 0x0035B264 File Offset: 0x00359464
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256069, XrefRangeEnd = 256074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealCompletionPopup.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x1700473E RID: 18238
				// (get) Token: 0x0600E521 RID: 58657 RVA: 0x0035B298 File Offset: 0x00359498
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealCompletionPopup.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E522 RID: 58658 RVA: 0x0006FB8A File Offset: 0x0006DD8A
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004735 RID: 18229
				// (get) Token: 0x0600E523 RID: 58659 RVA: 0x0035B2D8 File Offset: 0x003594D8
				// (set) Token: 0x0600E524 RID: 58660 RVA: 0x0006FB93 File Offset: 0x0006DD93
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004736 RID: 18230
				// (get) Token: 0x0600E525 RID: 58661 RVA: 0x0035B300 File Offset: 0x00359500
				// (set) Token: 0x0600E526 RID: 58662 RVA: 0x0006FBAE File Offset: 0x0006DDAE
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004737 RID: 18231
				// (get) Token: 0x0600E527 RID: 58663 RVA: 0x0035B330 File Offset: 0x00359530
				// (set) Token: 0x0600E528 RID: 58664 RVA: 0x0006FBCD File Offset: 0x0006DDCD
				public unsafe DealCompletionPopup.__c__DisplayClass18_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<DealCompletionPopup.__c__DisplayClass18_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004738 RID: 18232
				// (get) Token: 0x0600E529 RID: 58665 RVA: 0x0035B360 File Offset: 0x00359560
				// (set) Token: 0x0600E52A RID: 58666 RVA: 0x0006FBEC File Offset: 0x0006DDEC
				public unsafe float _paymentLerpTime_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique.NativeFieldInfoPtr__paymentLerpTime_5__2);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique.NativeFieldInfoPtr__paymentLerpTime_5__2)) = value;
					}
				}

				// Token: 0x17004739 RID: 18233
				// (get) Token: 0x0600E52B RID: 58667 RVA: 0x0035B388 File Offset: 0x00359588
				// (set) Token: 0x0600E52C RID: 58668 RVA: 0x0006FC07 File Offset: 0x0006DE07
				public unsafe float _satisfactionLerpTime_5__3
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique.NativeFieldInfoPtr__satisfactionLerpTime_5__3);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique.NativeFieldInfoPtr__satisfactionLerpTime_5__3)) = value;
					}
				}

				// Token: 0x1700473A RID: 18234
				// (get) Token: 0x0600E52D RID: 58669 RVA: 0x0035B3B0 File Offset: 0x003595B0
				// (set) Token: 0x0600E52E RID: 58670 RVA: 0x0006FC22 File Offset: 0x0006DE22
				public unsafe float _endDelta_5__4
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique.NativeFieldInfoPtr__endDelta_5__4);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique.NativeFieldInfoPtr__endDelta_5__4)) = value;
					}
				}

				// Token: 0x1700473B RID: 18235
				// (get) Token: 0x0600E52F RID: 58671 RVA: 0x0035B3D8 File Offset: 0x003595D8
				// (set) Token: 0x0600E530 RID: 58672 RVA: 0x0006FC3D File Offset: 0x0006DE3D
				public unsafe float _lerpTime_5__5
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique.NativeFieldInfoPtr__lerpTime_5__5);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique.NativeFieldInfoPtr__lerpTime_5__5)) = value;
					}
				}

				// Token: 0x1700473C RID: 18236
				// (get) Token: 0x0600E531 RID: 58673 RVA: 0x0035B400 File Offset: 0x00359600
				// (set) Token: 0x0600E532 RID: 58674 RVA: 0x0006FC58 File Offset: 0x0006DE58
				public unsafe float _i_5__6
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique.NativeFieldInfoPtr__i_5__6);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique.NativeFieldInfoPtr__i_5__6)) = value;
					}
				}

				// Token: 0x04009937 RID: 39223
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04009938 RID: 39224
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04009939 RID: 39225
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400993A RID: 39226
				private static readonly IntPtr NativeFieldInfoPtr__paymentLerpTime_5__2;

				// Token: 0x0400993B RID: 39227
				private static readonly IntPtr NativeFieldInfoPtr__satisfactionLerpTime_5__3;

				// Token: 0x0400993C RID: 39228
				private static readonly IntPtr NativeFieldInfoPtr__endDelta_5__4;

				// Token: 0x0400993D RID: 39229
				private static readonly IntPtr NativeFieldInfoPtr__lerpTime_5__5;

				// Token: 0x0400993E RID: 39230
				private static readonly IntPtr NativeFieldInfoPtr__i_5__6;

				// Token: 0x0400993F RID: 39231
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x04009940 RID: 39232
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009941 RID: 39233
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x04009942 RID: 39234
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04009943 RID: 39235
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009944 RID: 39236
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
