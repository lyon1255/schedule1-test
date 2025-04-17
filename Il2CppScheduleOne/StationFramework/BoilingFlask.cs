using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.ObjectScripts;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.StationFramework
{
	// Token: 0x02000584 RID: 1412
	public class BoilingFlask : Fillable
	{
		// Token: 0x06007C4C RID: 31820 RVA: 0x002166DC File Offset: 0x002148DC
		// Note: this type is marked as 'beforefieldinit'.
		static BoilingFlask()
		{
			Il2CppClassPointerStore<BoilingFlask>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.StationFramework", "BoilingFlask");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BoilingFlask>.NativeClassPtr);
			BoilingFlask.NativeFieldInfoPtr_TEMPERATURE_MAX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoilingFlask>.NativeClassPtr, "TEMPERATURE_MAX");
			BoilingFlask.NativeFieldInfoPtr_TEMPERATURE_MAX_VELOCITY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoilingFlask>.NativeClassPtr, "TEMPERATURE_MAX_VELOCITY");
			BoilingFlask.NativeFieldInfoPtr_TEMPERATURE_ACCELERATION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoilingFlask>.NativeClassPtr, "TEMPERATURE_ACCELERATION");
			BoilingFlask.NativeFieldInfoPtr_OVERHEAT_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoilingFlask>.NativeClassPtr, "OVERHEAT_TIME");
			BoilingFlask.NativeFieldInfoPtr__CurrentTemperature_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoilingFlask>.NativeClassPtr, "<CurrentTemperature>k__BackingField");
			BoilingFlask.NativeFieldInfoPtr__CurrentTemperatureVelocity_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoilingFlask>.NativeClassPtr, "<CurrentTemperatureVelocity>k__BackingField");
			BoilingFlask.NativeFieldInfoPtr__OverheatScale_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoilingFlask>.NativeClassPtr, "<OverheatScale>k__BackingField");
			BoilingFlask.NativeFieldInfoPtr__Recipe_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoilingFlask>.NativeClassPtr, "<Recipe>k__BackingField");
			BoilingFlask.NativeFieldInfoPtr_LockTemperature = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoilingFlask>.NativeClassPtr, "LockTemperature");
			BoilingFlask.NativeFieldInfoPtr_BoilSoundPitchCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoilingFlask>.NativeClassPtr, "BoilSoundPitchCurve");
			BoilingFlask.NativeFieldInfoPtr_LabelJitterScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoilingFlask>.NativeClassPtr, "LabelJitterScale");
			BoilingFlask.NativeFieldInfoPtr_Burner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoilingFlask>.NativeClassPtr, "Burner");
			BoilingFlask.NativeFieldInfoPtr_TemperatureCanvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoilingFlask>.NativeClassPtr, "TemperatureCanvas");
			BoilingFlask.NativeFieldInfoPtr_TemperatureLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoilingFlask>.NativeClassPtr, "TemperatureLabel");
			BoilingFlask.NativeFieldInfoPtr_TemperatureSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoilingFlask>.NativeClassPtr, "TemperatureSlider");
			BoilingFlask.NativeFieldInfoPtr_TemperatureRangeIndicator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoilingFlask>.NativeClassPtr, "TemperatureRangeIndicator");
			BoilingFlask.NativeFieldInfoPtr_SmokeParticles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoilingFlask>.NativeClassPtr, "SmokeParticles");
			BoilingFlask.NativeFieldInfoPtr_BoilSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoilingFlask>.NativeClassPtr, "BoilSound");
			BoilingFlask.NativeFieldInfoPtr_OverheatMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoilingFlask>.NativeClassPtr, "OverheatMesh");
			BoilingFlask.NativeMethodInfoPtr_get_CurrentTemperature_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoilingFlask>.NativeClassPtr, 100678879);
			BoilingFlask.NativeMethodInfoPtr_set_CurrentTemperature_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoilingFlask>.NativeClassPtr, 100678880);
			BoilingFlask.NativeMethodInfoPtr_get_CurrentTemperatureVelocity_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoilingFlask>.NativeClassPtr, 100678881);
			BoilingFlask.NativeMethodInfoPtr_set_CurrentTemperatureVelocity_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoilingFlask>.NativeClassPtr, 100678882);
			BoilingFlask.NativeMethodInfoPtr_get_IsTemperatureInRange_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoilingFlask>.NativeClassPtr, 100678883);
			BoilingFlask.NativeMethodInfoPtr_get_OverheatScale_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoilingFlask>.NativeClassPtr, 100678884);
			BoilingFlask.NativeMethodInfoPtr_set_OverheatScale_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoilingFlask>.NativeClassPtr, 100678885);
			BoilingFlask.NativeMethodInfoPtr_get_Recipe_Public_get_StationRecipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoilingFlask>.NativeClassPtr, 100678886);
			BoilingFlask.NativeMethodInfoPtr_set_Recipe_Private_set_Void_StationRecipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoilingFlask>.NativeClassPtr, 100678887);
			BoilingFlask.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoilingFlask>.NativeClassPtr, 100678888);
			BoilingFlask.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoilingFlask>.NativeClassPtr, 100678889);
			BoilingFlask.NativeMethodInfoPtr_UpdateCanvas_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoilingFlask>.NativeClassPtr, 100678890);
			BoilingFlask.NativeMethodInfoPtr_UpdateSmoke_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoilingFlask>.NativeClassPtr, 100678891);
			BoilingFlask.NativeMethodInfoPtr_SetCanvasVisible_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoilingFlask>.NativeClassPtr, 100678892);
			BoilingFlask.NativeMethodInfoPtr_SetTemperature_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoilingFlask>.NativeClassPtr, 100678893);
			BoilingFlask.NativeMethodInfoPtr_SetRecipe_Public_Void_StationRecipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoilingFlask>.NativeClassPtr, 100678894);
			BoilingFlask.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoilingFlask>.NativeClassPtr, 100678895);
		}

		// Token: 0x170025A3 RID: 9635
		// (get) Token: 0x06007C4D RID: 31821 RVA: 0x002169DC File Offset: 0x00214BDC
		// (set) Token: 0x06007C4E RID: 31822 RVA: 0x00216A18 File Offset: 0x00214C18
		public unsafe float CurrentTemperature
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 30023, RefRangeEnd = 30024, XrefRangeStart = 30023, XrefRangeEnd = 30024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoilingFlask.NativeMethodInfoPtr_get_CurrentTemperature_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 30024, RefRangeEnd = 30027, XrefRangeStart = 30024, XrefRangeEnd = 30027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoilingFlask.NativeMethodInfoPtr_set_CurrentTemperature_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170025A4 RID: 9636
		// (get) Token: 0x06007C4F RID: 31823 RVA: 0x00216A58 File Offset: 0x00214C58
		// (set) Token: 0x06007C50 RID: 31824 RVA: 0x00216A94 File Offset: 0x00214C94
		public unsafe float CurrentTemperatureVelocity
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 30027, RefRangeEnd = 30028, XrefRangeStart = 30027, XrefRangeEnd = 30028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoilingFlask.NativeMethodInfoPtr_get_CurrentTemperatureVelocity_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoilingFlask.NativeMethodInfoPtr_set_CurrentTemperatureVelocity_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170025A5 RID: 9637
		// (get) Token: 0x06007C51 RID: 31825 RVA: 0x00216AD4 File Offset: 0x00214CD4
		public unsafe bool IsTemperatureInRange
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 237164, RefRangeEnd = 237165, XrefRangeStart = 237160, XrefRangeEnd = 237164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoilingFlask.NativeMethodInfoPtr_get_IsTemperatureInRange_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170025A6 RID: 9638
		// (get) Token: 0x06007C52 RID: 31826 RVA: 0x00216B10 File Offset: 0x00214D10
		// (set) Token: 0x06007C53 RID: 31827 RVA: 0x00216B4C File Offset: 0x00214D4C
		public unsafe float OverheatScale
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoilingFlask.NativeMethodInfoPtr_get_OverheatScale_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoilingFlask.NativeMethodInfoPtr_set_OverheatScale_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170025A7 RID: 9639
		// (get) Token: 0x06007C54 RID: 31828 RVA: 0x00216B8C File Offset: 0x00214D8C
		// (set) Token: 0x06007C55 RID: 31829 RVA: 0x00216BCC File Offset: 0x00214DCC
		public unsafe StationRecipe Recipe
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 16596, RefRangeEnd = 16597, XrefRangeStart = 16596, XrefRangeEnd = 16597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoilingFlask.NativeMethodInfoPtr_get_Recipe_Public_get_StationRecipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StationRecipe>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 38372, RefRangeEnd = 38373, XrefRangeStart = 38372, XrefRangeEnd = 38373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoilingFlask.NativeMethodInfoPtr_set_Recipe_Private_set_Void_StationRecipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06007C56 RID: 31830 RVA: 0x00216C10 File Offset: 0x00214E10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237165, XrefRangeEnd = 237193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoilingFlask.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007C57 RID: 31831 RVA: 0x00216C44 File Offset: 0x00214E44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237193, XrefRangeEnd = 237202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoilingFlask.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007C58 RID: 31832 RVA: 0x00216C78 File Offset: 0x00214E78
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 237215, RefRangeEnd = 237216, XrefRangeStart = 237202, XrefRangeEnd = 237215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateCanvas()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoilingFlask.NativeMethodInfoPtr_UpdateCanvas_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007C59 RID: 31833 RVA: 0x00216CAC File Offset: 0x00214EAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237216, XrefRangeEnd = 237224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateSmoke()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoilingFlask.NativeMethodInfoPtr_UpdateSmoke_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007C5A RID: 31834 RVA: 0x00216CE0 File Offset: 0x00214EE0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 237227, RefRangeEnd = 237230, XrefRangeStart = 237224, XrefRangeEnd = 237227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCanvasVisible(bool visible)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref visible;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoilingFlask.NativeMethodInfoPtr_SetCanvasVisible_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007C5B RID: 31835 RVA: 0x00216D20 File Offset: 0x00214F20
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 30024, RefRangeEnd = 30027, XrefRangeStart = 30024, XrefRangeEnd = 30027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetTemperature(float temp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref temp;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoilingFlask.NativeMethodInfoPtr_SetTemperature_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007C5C RID: 31836 RVA: 0x00216D60 File Offset: 0x00214F60
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 237239, RefRangeEnd = 237242, XrefRangeStart = 237230, XrefRangeEnd = 237239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetRecipe(StationRecipe recipe)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(recipe);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoilingFlask.NativeMethodInfoPtr_SetRecipe_Public_Void_StationRecipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007C5D RID: 31837 RVA: 0x00216DA4 File Offset: 0x00214FA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237242, XrefRangeEnd = 237250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BoilingFlask() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BoilingFlask>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoilingFlask.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007C5E RID: 31838 RVA: 0x0003AF7D File Offset: 0x0003917D
		public BoilingFlask(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002590 RID: 9616
		// (get) Token: 0x06007C5F RID: 31839 RVA: 0x00216DE0 File Offset: 0x00214FE0
		// (set) Token: 0x06007C60 RID: 31840 RVA: 0x0003AF86 File Offset: 0x00039186
		public unsafe static float TEMPERATURE_MAX
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(BoilingFlask.NativeFieldInfoPtr_TEMPERATURE_MAX, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BoilingFlask.NativeFieldInfoPtr_TEMPERATURE_MAX, (void*)(&value));
			}
		}

		// Token: 0x17002591 RID: 9617
		// (get) Token: 0x06007C61 RID: 31841 RVA: 0x00216DFC File Offset: 0x00214FFC
		// (set) Token: 0x06007C62 RID: 31842 RVA: 0x0003AF94 File Offset: 0x00039194
		public unsafe float TEMPERATURE_MAX_VELOCITY
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoilingFlask.NativeFieldInfoPtr_TEMPERATURE_MAX_VELOCITY);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoilingFlask.NativeFieldInfoPtr_TEMPERATURE_MAX_VELOCITY)) = value;
			}
		}

		// Token: 0x17002592 RID: 9618
		// (get) Token: 0x06007C63 RID: 31843 RVA: 0x00216E24 File Offset: 0x00215024
		// (set) Token: 0x06007C64 RID: 31844 RVA: 0x0003AFAF File Offset: 0x000391AF
		public unsafe float TEMPERATURE_ACCELERATION
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoilingFlask.NativeFieldInfoPtr_TEMPERATURE_ACCELERATION);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoilingFlask.NativeFieldInfoPtr_TEMPERATURE_ACCELERATION)) = value;
			}
		}

		// Token: 0x17002593 RID: 9619
		// (get) Token: 0x06007C65 RID: 31845 RVA: 0x00216E4C File Offset: 0x0021504C
		// (set) Token: 0x06007C66 RID: 31846 RVA: 0x0003AFCA File Offset: 0x000391CA
		public unsafe static float OVERHEAT_TIME
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(BoilingFlask.NativeFieldInfoPtr_OVERHEAT_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BoilingFlask.NativeFieldInfoPtr_OVERHEAT_TIME, (void*)(&value));
			}
		}

		// Token: 0x17002594 RID: 9620
		// (get) Token: 0x06007C67 RID: 31847 RVA: 0x00216E68 File Offset: 0x00215068
		// (set) Token: 0x06007C68 RID: 31848 RVA: 0x0003AFD8 File Offset: 0x000391D8
		public unsafe float _CurrentTemperature_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoilingFlask.NativeFieldInfoPtr__CurrentTemperature_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoilingFlask.NativeFieldInfoPtr__CurrentTemperature_k__BackingField)) = value;
			}
		}

		// Token: 0x17002595 RID: 9621
		// (get) Token: 0x06007C69 RID: 31849 RVA: 0x00216E90 File Offset: 0x00215090
		// (set) Token: 0x06007C6A RID: 31850 RVA: 0x0003AFF3 File Offset: 0x000391F3
		public unsafe float _CurrentTemperatureVelocity_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoilingFlask.NativeFieldInfoPtr__CurrentTemperatureVelocity_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoilingFlask.NativeFieldInfoPtr__CurrentTemperatureVelocity_k__BackingField)) = value;
			}
		}

		// Token: 0x17002596 RID: 9622
		// (get) Token: 0x06007C6B RID: 31851 RVA: 0x00216EB8 File Offset: 0x002150B8
		// (set) Token: 0x06007C6C RID: 31852 RVA: 0x0003B00E File Offset: 0x0003920E
		public unsafe float _OverheatScale_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoilingFlask.NativeFieldInfoPtr__OverheatScale_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoilingFlask.NativeFieldInfoPtr__OverheatScale_k__BackingField)) = value;
			}
		}

		// Token: 0x17002597 RID: 9623
		// (get) Token: 0x06007C6D RID: 31853 RVA: 0x00216EE0 File Offset: 0x002150E0
		// (set) Token: 0x06007C6E RID: 31854 RVA: 0x0003B029 File Offset: 0x00039229
		public unsafe StationRecipe _Recipe_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoilingFlask.NativeFieldInfoPtr__Recipe_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StationRecipe>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoilingFlask.NativeFieldInfoPtr__Recipe_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002598 RID: 9624
		// (get) Token: 0x06007C6F RID: 31855 RVA: 0x00216F10 File Offset: 0x00215110
		// (set) Token: 0x06007C70 RID: 31856 RVA: 0x0003B048 File Offset: 0x00039248
		public unsafe bool LockTemperature
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoilingFlask.NativeFieldInfoPtr_LockTemperature);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoilingFlask.NativeFieldInfoPtr_LockTemperature)) = value;
			}
		}

		// Token: 0x17002599 RID: 9625
		// (get) Token: 0x06007C71 RID: 31857 RVA: 0x00216F38 File Offset: 0x00215138
		// (set) Token: 0x06007C72 RID: 31858 RVA: 0x0003B063 File Offset: 0x00039263
		public unsafe AnimationCurve BoilSoundPitchCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoilingFlask.NativeFieldInfoPtr_BoilSoundPitchCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoilingFlask.NativeFieldInfoPtr_BoilSoundPitchCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700259A RID: 9626
		// (get) Token: 0x06007C73 RID: 31859 RVA: 0x00216F68 File Offset: 0x00215168
		// (set) Token: 0x06007C74 RID: 31860 RVA: 0x0003B082 File Offset: 0x00039282
		public unsafe float LabelJitterScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoilingFlask.NativeFieldInfoPtr_LabelJitterScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoilingFlask.NativeFieldInfoPtr_LabelJitterScale)) = value;
			}
		}

		// Token: 0x1700259B RID: 9627
		// (get) Token: 0x06007C75 RID: 31861 RVA: 0x00216F90 File Offset: 0x00215190
		// (set) Token: 0x06007C76 RID: 31862 RVA: 0x0003B09D File Offset: 0x0003929D
		public unsafe BunsenBurner Burner
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoilingFlask.NativeFieldInfoPtr_Burner);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BunsenBurner>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoilingFlask.NativeFieldInfoPtr_Burner), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700259C RID: 9628
		// (get) Token: 0x06007C77 RID: 31863 RVA: 0x00216FC0 File Offset: 0x002151C0
		// (set) Token: 0x06007C78 RID: 31864 RVA: 0x0003B0BC File Offset: 0x000392BC
		public unsafe Canvas TemperatureCanvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoilingFlask.NativeFieldInfoPtr_TemperatureCanvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoilingFlask.NativeFieldInfoPtr_TemperatureCanvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700259D RID: 9629
		// (get) Token: 0x06007C79 RID: 31865 RVA: 0x00216FF0 File Offset: 0x002151F0
		// (set) Token: 0x06007C7A RID: 31866 RVA: 0x0003B0DB File Offset: 0x000392DB
		public unsafe TextMeshProUGUI TemperatureLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoilingFlask.NativeFieldInfoPtr_TemperatureLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoilingFlask.NativeFieldInfoPtr_TemperatureLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700259E RID: 9630
		// (get) Token: 0x06007C7B RID: 31867 RVA: 0x00217020 File Offset: 0x00215220
		// (set) Token: 0x06007C7C RID: 31868 RVA: 0x0003B0FA File Offset: 0x000392FA
		public unsafe Slider TemperatureSlider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoilingFlask.NativeFieldInfoPtr_TemperatureSlider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Slider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoilingFlask.NativeFieldInfoPtr_TemperatureSlider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700259F RID: 9631
		// (get) Token: 0x06007C7D RID: 31869 RVA: 0x00217050 File Offset: 0x00215250
		// (set) Token: 0x06007C7E RID: 31870 RVA: 0x0003B119 File Offset: 0x00039319
		public unsafe RectTransform TemperatureRangeIndicator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoilingFlask.NativeFieldInfoPtr_TemperatureRangeIndicator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoilingFlask.NativeFieldInfoPtr_TemperatureRangeIndicator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025A0 RID: 9632
		// (get) Token: 0x06007C7F RID: 31871 RVA: 0x00217080 File Offset: 0x00215280
		// (set) Token: 0x06007C80 RID: 31872 RVA: 0x0003B138 File Offset: 0x00039338
		public unsafe ParticleSystem SmokeParticles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoilingFlask.NativeFieldInfoPtr_SmokeParticles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoilingFlask.NativeFieldInfoPtr_SmokeParticles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025A1 RID: 9633
		// (get) Token: 0x06007C81 RID: 31873 RVA: 0x002170B0 File Offset: 0x002152B0
		// (set) Token: 0x06007C82 RID: 31874 RVA: 0x0003B157 File Offset: 0x00039357
		public unsafe AudioSourceController BoilSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoilingFlask.NativeFieldInfoPtr_BoilSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoilingFlask.NativeFieldInfoPtr_BoilSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170025A2 RID: 9634
		// (get) Token: 0x06007C83 RID: 31875 RVA: 0x002170E0 File Offset: 0x002152E0
		// (set) Token: 0x06007C84 RID: 31876 RVA: 0x0003B176 File Offset: 0x00039376
		public unsafe MeshRenderer OverheatMesh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoilingFlask.NativeFieldInfoPtr_OverheatMesh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoilingFlask.NativeFieldInfoPtr_OverheatMesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040054A4 RID: 21668
		private static readonly IntPtr NativeFieldInfoPtr_TEMPERATURE_MAX;

		// Token: 0x040054A5 RID: 21669
		private static readonly IntPtr NativeFieldInfoPtr_TEMPERATURE_MAX_VELOCITY;

		// Token: 0x040054A6 RID: 21670
		private static readonly IntPtr NativeFieldInfoPtr_TEMPERATURE_ACCELERATION;

		// Token: 0x040054A7 RID: 21671
		private static readonly IntPtr NativeFieldInfoPtr_OVERHEAT_TIME;

		// Token: 0x040054A8 RID: 21672
		private static readonly IntPtr NativeFieldInfoPtr__CurrentTemperature_k__BackingField;

		// Token: 0x040054A9 RID: 21673
		private static readonly IntPtr NativeFieldInfoPtr__CurrentTemperatureVelocity_k__BackingField;

		// Token: 0x040054AA RID: 21674
		private static readonly IntPtr NativeFieldInfoPtr__OverheatScale_k__BackingField;

		// Token: 0x040054AB RID: 21675
		private static readonly IntPtr NativeFieldInfoPtr__Recipe_k__BackingField;

		// Token: 0x040054AC RID: 21676
		private static readonly IntPtr NativeFieldInfoPtr_LockTemperature;

		// Token: 0x040054AD RID: 21677
		private static readonly IntPtr NativeFieldInfoPtr_BoilSoundPitchCurve;

		// Token: 0x040054AE RID: 21678
		private static readonly IntPtr NativeFieldInfoPtr_LabelJitterScale;

		// Token: 0x040054AF RID: 21679
		private static readonly IntPtr NativeFieldInfoPtr_Burner;

		// Token: 0x040054B0 RID: 21680
		private static readonly IntPtr NativeFieldInfoPtr_TemperatureCanvas;

		// Token: 0x040054B1 RID: 21681
		private static readonly IntPtr NativeFieldInfoPtr_TemperatureLabel;

		// Token: 0x040054B2 RID: 21682
		private static readonly IntPtr NativeFieldInfoPtr_TemperatureSlider;

		// Token: 0x040054B3 RID: 21683
		private static readonly IntPtr NativeFieldInfoPtr_TemperatureRangeIndicator;

		// Token: 0x040054B4 RID: 21684
		private static readonly IntPtr NativeFieldInfoPtr_SmokeParticles;

		// Token: 0x040054B5 RID: 21685
		private static readonly IntPtr NativeFieldInfoPtr_BoilSound;

		// Token: 0x040054B6 RID: 21686
		private static readonly IntPtr NativeFieldInfoPtr_OverheatMesh;

		// Token: 0x040054B7 RID: 21687
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentTemperature_Public_get_Single_0;

		// Token: 0x040054B8 RID: 21688
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentTemperature_Private_set_Void_Single_0;

		// Token: 0x040054B9 RID: 21689
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentTemperatureVelocity_Public_get_Single_0;

		// Token: 0x040054BA RID: 21690
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentTemperatureVelocity_Private_set_Void_Single_0;

		// Token: 0x040054BB RID: 21691
		private static readonly IntPtr NativeMethodInfoPtr_get_IsTemperatureInRange_Public_get_Boolean_0;

		// Token: 0x040054BC RID: 21692
		private static readonly IntPtr NativeMethodInfoPtr_get_OverheatScale_Public_get_Single_0;

		// Token: 0x040054BD RID: 21693
		private static readonly IntPtr NativeMethodInfoPtr_set_OverheatScale_Private_set_Void_Single_0;

		// Token: 0x040054BE RID: 21694
		private static readonly IntPtr NativeMethodInfoPtr_get_Recipe_Public_get_StationRecipe_0;

		// Token: 0x040054BF RID: 21695
		private static readonly IntPtr NativeMethodInfoPtr_set_Recipe_Private_set_Void_StationRecipe_0;

		// Token: 0x040054C0 RID: 21696
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

		// Token: 0x040054C1 RID: 21697
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

		// Token: 0x040054C2 RID: 21698
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCanvas_Private_Void_0;

		// Token: 0x040054C3 RID: 21699
		private static readonly IntPtr NativeMethodInfoPtr_UpdateSmoke_Private_Void_0;

		// Token: 0x040054C4 RID: 21700
		private static readonly IntPtr NativeMethodInfoPtr_SetCanvasVisible_Public_Void_Boolean_0;

		// Token: 0x040054C5 RID: 21701
		private static readonly IntPtr NativeMethodInfoPtr_SetTemperature_Public_Void_Single_0;

		// Token: 0x040054C6 RID: 21702
		private static readonly IntPtr NativeMethodInfoPtr_SetRecipe_Public_Void_StationRecipe_0;

		// Token: 0x040054C7 RID: 21703
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
