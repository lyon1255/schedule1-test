using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.Trash;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppScheduleOne.Equipping
{
	// Token: 0x020005B6 RID: 1462
	public class Equippable_Cuke : Equippable_Viewmodel
	{
		// Token: 0x0600805D RID: 32861 RVA: 0x00225214 File Offset: 0x00223414
		// Note: this type is marked as 'beforefieldinit'.
		static Equippable_Cuke()
		{
			Il2CppClassPointerStore<Equippable_Cuke>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Equipping", "Equippable_Cuke");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Equippable_Cuke>.NativeClassPtr);
			Equippable_Cuke.NativeFieldInfoPtr__IsDrinking_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_Cuke>.NativeClassPtr, "<IsDrinking>k__BackingField");
			Equippable_Cuke.NativeFieldInfoPtr_BaseEnergyGain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_Cuke>.NativeClassPtr, "BaseEnergyGain");
			Equippable_Cuke.NativeFieldInfoPtr_MinEnergyGain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_Cuke>.NativeClassPtr, "MinEnergyGain");
			Equippable_Cuke.NativeFieldInfoPtr_ConsecutiveReduction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_Cuke>.NativeClassPtr, "ConsecutiveReduction");
			Equippable_Cuke.NativeFieldInfoPtr_HealthGain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_Cuke>.NativeClassPtr, "HealthGain");
			Equippable_Cuke.NativeFieldInfoPtr_AnimationDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_Cuke>.NativeClassPtr, "AnimationDuration");
			Equippable_Cuke.NativeFieldInfoPtr_ClearDrugEffects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_Cuke>.NativeClassPtr, "ClearDrugEffects");
			Equippable_Cuke.NativeFieldInfoPtr_OpenAnim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_Cuke>.NativeClassPtr, "OpenAnim");
			Equippable_Cuke.NativeFieldInfoPtr_DrinkAnim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_Cuke>.NativeClassPtr, "DrinkAnim");
			Equippable_Cuke.NativeFieldInfoPtr_OpenSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_Cuke>.NativeClassPtr, "OpenSound");
			Equippable_Cuke.NativeFieldInfoPtr_SlurpSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_Cuke>.NativeClassPtr, "SlurpSound");
			Equippable_Cuke.NativeFieldInfoPtr_TrashPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_Cuke>.NativeClassPtr, "TrashPrefab");
			Equippable_Cuke.NativeMethodInfoPtr_get_IsDrinking_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Cuke>.NativeClassPtr, 100679410);
			Equippable_Cuke.NativeMethodInfoPtr_set_IsDrinking_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Cuke>.NativeClassPtr, 100679411);
			Equippable_Cuke.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Cuke>.NativeClassPtr, 100679412);
			Equippable_Cuke.NativeMethodInfoPtr_Drink_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Cuke>.NativeClassPtr, 100679413);
			Equippable_Cuke.NativeMethodInfoPtr_ApplyEffects_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Cuke>.NativeClassPtr, 100679414);
			Equippable_Cuke.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Cuke>.NativeClassPtr, 100679415);
			Equippable_Cuke.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Cuke>.NativeClassPtr, 100679416);
		}

		// Token: 0x170026D1 RID: 9937
		// (get) Token: 0x0600805E RID: 32862 RVA: 0x002253C0 File Offset: 0x002235C0
		// (set) Token: 0x0600805F RID: 32863 RVA: 0x002253FC File Offset: 0x002235FC
		public unsafe bool IsDrinking
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_Cuke.NativeMethodInfoPtr_get_IsDrinking_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_Cuke.NativeMethodInfoPtr_set_IsDrinking_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06008060 RID: 32864 RVA: 0x0022543C File Offset: 0x0022363C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244199, XrefRangeEnd = 244216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_Cuke.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008061 RID: 32865 RVA: 0x00225478 File Offset: 0x00223678
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244216, XrefRangeEnd = 244222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Drink()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_Cuke.NativeMethodInfoPtr_Drink_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008062 RID: 32866 RVA: 0x002254AC File Offset: 0x002236AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 244251, RefRangeEnd = 244252, XrefRangeStart = 244222, XrefRangeEnd = 244251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyEffects()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_Cuke.NativeMethodInfoPtr_ApplyEffects_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008063 RID: 32867 RVA: 0x002254E0 File Offset: 0x002236E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244252, XrefRangeEnd = 244255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Equippable_Cuke() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Equippable_Cuke>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_Cuke.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008064 RID: 32868 RVA: 0x0022551C File Offset: 0x0022371C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244255, XrefRangeEnd = 244260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_Cuke.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06008065 RID: 32869 RVA: 0x0003CE0F File Offset: 0x0003B00F
		public Equippable_Cuke(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170026C5 RID: 9925
		// (get) Token: 0x06008066 RID: 32870 RVA: 0x0022555C File Offset: 0x0022375C
		// (set) Token: 0x06008067 RID: 32871 RVA: 0x0003CE18 File Offset: 0x0003B018
		public unsafe bool _IsDrinking_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cuke.NativeFieldInfoPtr__IsDrinking_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cuke.NativeFieldInfoPtr__IsDrinking_k__BackingField)) = value;
			}
		}

		// Token: 0x170026C6 RID: 9926
		// (get) Token: 0x06008068 RID: 32872 RVA: 0x00225584 File Offset: 0x00223784
		// (set) Token: 0x06008069 RID: 32873 RVA: 0x0003CE33 File Offset: 0x0003B033
		public unsafe float BaseEnergyGain
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cuke.NativeFieldInfoPtr_BaseEnergyGain);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cuke.NativeFieldInfoPtr_BaseEnergyGain)) = value;
			}
		}

		// Token: 0x170026C7 RID: 9927
		// (get) Token: 0x0600806A RID: 32874 RVA: 0x002255AC File Offset: 0x002237AC
		// (set) Token: 0x0600806B RID: 32875 RVA: 0x0003CE4E File Offset: 0x0003B04E
		public unsafe float MinEnergyGain
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cuke.NativeFieldInfoPtr_MinEnergyGain);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cuke.NativeFieldInfoPtr_MinEnergyGain)) = value;
			}
		}

		// Token: 0x170026C8 RID: 9928
		// (get) Token: 0x0600806C RID: 32876 RVA: 0x002255D4 File Offset: 0x002237D4
		// (set) Token: 0x0600806D RID: 32877 RVA: 0x0003CE69 File Offset: 0x0003B069
		public unsafe float ConsecutiveReduction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cuke.NativeFieldInfoPtr_ConsecutiveReduction);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cuke.NativeFieldInfoPtr_ConsecutiveReduction)) = value;
			}
		}

		// Token: 0x170026C9 RID: 9929
		// (get) Token: 0x0600806E RID: 32878 RVA: 0x002255FC File Offset: 0x002237FC
		// (set) Token: 0x0600806F RID: 32879 RVA: 0x0003CE84 File Offset: 0x0003B084
		public unsafe float HealthGain
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cuke.NativeFieldInfoPtr_HealthGain);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cuke.NativeFieldInfoPtr_HealthGain)) = value;
			}
		}

		// Token: 0x170026CA RID: 9930
		// (get) Token: 0x06008070 RID: 32880 RVA: 0x00225624 File Offset: 0x00223824
		// (set) Token: 0x06008071 RID: 32881 RVA: 0x0003CE9F File Offset: 0x0003B09F
		public unsafe float AnimationDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cuke.NativeFieldInfoPtr_AnimationDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cuke.NativeFieldInfoPtr_AnimationDuration)) = value;
			}
		}

		// Token: 0x170026CB RID: 9931
		// (get) Token: 0x06008072 RID: 32882 RVA: 0x0022564C File Offset: 0x0022384C
		// (set) Token: 0x06008073 RID: 32883 RVA: 0x0003CEBA File Offset: 0x0003B0BA
		public unsafe bool ClearDrugEffects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cuke.NativeFieldInfoPtr_ClearDrugEffects);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cuke.NativeFieldInfoPtr_ClearDrugEffects)) = value;
			}
		}

		// Token: 0x170026CC RID: 9932
		// (get) Token: 0x06008074 RID: 32884 RVA: 0x00225674 File Offset: 0x00223874
		// (set) Token: 0x06008075 RID: 32885 RVA: 0x0003CED5 File Offset: 0x0003B0D5
		public unsafe Animation OpenAnim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cuke.NativeFieldInfoPtr_OpenAnim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cuke.NativeFieldInfoPtr_OpenAnim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170026CD RID: 9933
		// (get) Token: 0x06008076 RID: 32886 RVA: 0x002256A4 File Offset: 0x002238A4
		// (set) Token: 0x06008077 RID: 32887 RVA: 0x0003CEF4 File Offset: 0x0003B0F4
		public unsafe Animation DrinkAnim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cuke.NativeFieldInfoPtr_DrinkAnim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cuke.NativeFieldInfoPtr_DrinkAnim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170026CE RID: 9934
		// (get) Token: 0x06008078 RID: 32888 RVA: 0x002256D4 File Offset: 0x002238D4
		// (set) Token: 0x06008079 RID: 32889 RVA: 0x0003CF13 File Offset: 0x0003B113
		public unsafe AudioSourceController OpenSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cuke.NativeFieldInfoPtr_OpenSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cuke.NativeFieldInfoPtr_OpenSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170026CF RID: 9935
		// (get) Token: 0x0600807A RID: 32890 RVA: 0x00225704 File Offset: 0x00223904
		// (set) Token: 0x0600807B RID: 32891 RVA: 0x0003CF32 File Offset: 0x0003B132
		public unsafe AudioSourceController SlurpSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cuke.NativeFieldInfoPtr_SlurpSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cuke.NativeFieldInfoPtr_SlurpSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170026D0 RID: 9936
		// (get) Token: 0x0600807C RID: 32892 RVA: 0x00225734 File Offset: 0x00223934
		// (set) Token: 0x0600807D RID: 32893 RVA: 0x0003CF51 File Offset: 0x0003B151
		public unsafe TrashItem TrashPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cuke.NativeFieldInfoPtr_TrashPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TrashItem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cuke.NativeFieldInfoPtr_TrashPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005773 RID: 22387
		private static readonly IntPtr NativeFieldInfoPtr__IsDrinking_k__BackingField;

		// Token: 0x04005774 RID: 22388
		private static readonly IntPtr NativeFieldInfoPtr_BaseEnergyGain;

		// Token: 0x04005775 RID: 22389
		private static readonly IntPtr NativeFieldInfoPtr_MinEnergyGain;

		// Token: 0x04005776 RID: 22390
		private static readonly IntPtr NativeFieldInfoPtr_ConsecutiveReduction;

		// Token: 0x04005777 RID: 22391
		private static readonly IntPtr NativeFieldInfoPtr_HealthGain;

		// Token: 0x04005778 RID: 22392
		private static readonly IntPtr NativeFieldInfoPtr_AnimationDuration;

		// Token: 0x04005779 RID: 22393
		private static readonly IntPtr NativeFieldInfoPtr_ClearDrugEffects;

		// Token: 0x0400577A RID: 22394
		private static readonly IntPtr NativeFieldInfoPtr_OpenAnim;

		// Token: 0x0400577B RID: 22395
		private static readonly IntPtr NativeFieldInfoPtr_DrinkAnim;

		// Token: 0x0400577C RID: 22396
		private static readonly IntPtr NativeFieldInfoPtr_OpenSound;

		// Token: 0x0400577D RID: 22397
		private static readonly IntPtr NativeFieldInfoPtr_SlurpSound;

		// Token: 0x0400577E RID: 22398
		private static readonly IntPtr NativeFieldInfoPtr_TrashPrefab;

		// Token: 0x0400577F RID: 22399
		private static readonly IntPtr NativeMethodInfoPtr_get_IsDrinking_Public_get_Boolean_0;

		// Token: 0x04005780 RID: 22400
		private static readonly IntPtr NativeMethodInfoPtr_set_IsDrinking_Protected_set_Void_Boolean_0;

		// Token: 0x04005781 RID: 22401
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_Void_0;

		// Token: 0x04005782 RID: 22402
		private static readonly IntPtr NativeMethodInfoPtr_Drink_Public_Void_0;

		// Token: 0x04005783 RID: 22403
		private static readonly IntPtr NativeMethodInfoPtr_ApplyEffects_Public_Void_0;

		// Token: 0x04005784 RID: 22404
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04005785 RID: 22405
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x02000ADE RID: 2782
		[ObfuscatedName("ScheduleOne.Equipping.Equippable_Cuke+<<Drink>g__DrinkRoutine|16_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600D4EE RID: 54510 RVA: 0x0032C634 File Offset: 0x0032A834
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique()
			{
				Il2CppClassPointerStore<Equippable_Cuke.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Equippable_Cuke>.NativeClassPtr, "<<Drink>g__DrinkRoutine|16_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Equippable_Cuke.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique>.NativeClassPtr);
				Equippable_Cuke.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_Cuke.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique>.NativeClassPtr, "<>1__state");
				Equippable_Cuke.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_Cuke.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique>.NativeClassPtr, "<>2__current");
				Equippable_Cuke.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_Cuke.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique>.NativeClassPtr, "<>4__this");
				Equippable_Cuke.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Cuke.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique>.NativeClassPtr, 100679417);
				Equippable_Cuke.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Cuke.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique>.NativeClassPtr, 100679418);
				Equippable_Cuke.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Cuke.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique>.NativeClassPtr, 100679419);
				Equippable_Cuke.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Cuke.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique>.NativeClassPtr, 100679420);
				Equippable_Cuke.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Cuke.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique>.NativeClassPtr, 100679421);
				Equippable_Cuke.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Cuke.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique>.NativeClassPtr, 100679422);
			}

			// Token: 0x0600D4EF RID: 54511 RVA: 0x0032C714 File Offset: 0x0032A914
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Equippable_Cuke.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_Cuke.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D4F0 RID: 54512 RVA: 0x0032C75C File Offset: 0x0032A95C
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_Cuke.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D4F1 RID: 54513 RVA: 0x0032C790 File Offset: 0x0032A990
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244148, XrefRangeEnd = 244194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_Cuke.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170041FC RID: 16892
			// (get) Token: 0x0600D4F2 RID: 54514 RVA: 0x0032C7CC File Offset: 0x0032A9CC
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_Cuke.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D4F3 RID: 54515 RVA: 0x0032C80C File Offset: 0x0032AA0C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244194, XrefRangeEnd = 244199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_Cuke.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170041FD RID: 16893
			// (get) Token: 0x0600D4F4 RID: 54516 RVA: 0x0032C840 File Offset: 0x0032AA40
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_Cuke.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D4F5 RID: 54517 RVA: 0x000679CE File Offset: 0x00065BCE
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170041F9 RID: 16889
			// (get) Token: 0x0600D4F6 RID: 54518 RVA: 0x0032C880 File Offset: 0x0032AA80
			// (set) Token: 0x0600D4F7 RID: 54519 RVA: 0x000679D7 File Offset: 0x00065BD7
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cuke.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cuke.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170041FA RID: 16890
			// (get) Token: 0x0600D4F8 RID: 54520 RVA: 0x0032C8A8 File Offset: 0x0032AAA8
			// (set) Token: 0x0600D4F9 RID: 54521 RVA: 0x000679F2 File Offset: 0x00065BF2
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cuke.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cuke.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041FB RID: 16891
			// (get) Token: 0x0600D4FA RID: 54522 RVA: 0x0032C8D8 File Offset: 0x0032AAD8
			// (set) Token: 0x0600D4FB RID: 54523 RVA: 0x00067A11 File Offset: 0x00065C11
			public unsafe Equippable_Cuke __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cuke.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Equippable_Cuke>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cuke.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEqObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008F40 RID: 36672
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008F41 RID: 36673
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008F42 RID: 36674
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008F43 RID: 36675
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008F44 RID: 36676
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008F45 RID: 36677
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008F46 RID: 36678
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008F47 RID: 36679
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008F48 RID: 36680
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
