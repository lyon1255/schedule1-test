using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Product;
using Il2CppScheduleOne.Properties;
using Il2CppScheduleOne.Storage;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x0200062D RID: 1581
	public class CreateMixInterface : Singleton<CreateMixInterface>
	{
		// Token: 0x06008B5C RID: 35676 RVA: 0x00247378 File Offset: 0x00245578
		// Note: this type is marked as 'beforefieldinit'.
		static CreateMixInterface()
		{
			Il2CppClassPointerStore<CreateMixInterface>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "CreateMixInterface");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CreateMixInterface>.NativeClassPtr);
			CreateMixInterface.NativeFieldInfoPtr_BEAN_REQUIREMENT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateMixInterface>.NativeClassPtr, "BEAN_REQUIREMENT");
			CreateMixInterface.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateMixInterface>.NativeClassPtr, "<IsOpen>k__BackingField");
			CreateMixInterface.NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateMixInterface>.NativeClassPtr, "Canvas");
			CreateMixInterface.NativeFieldInfoPtr_BeansSlot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateMixInterface>.NativeClassPtr, "BeansSlot");
			CreateMixInterface.NativeFieldInfoPtr_ProductSlot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateMixInterface>.NativeClassPtr, "ProductSlot");
			CreateMixInterface.NativeFieldInfoPtr_MixerSlot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateMixInterface>.NativeClassPtr, "MixerSlot");
			CreateMixInterface.NativeFieldInfoPtr_OutputSlot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateMixInterface>.NativeClassPtr, "OutputSlot");
			CreateMixInterface.NativeFieldInfoPtr_OutputIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateMixInterface>.NativeClassPtr, "OutputIcon");
			CreateMixInterface.NativeFieldInfoPtr_BeginButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateMixInterface>.NativeClassPtr, "BeginButton");
			CreateMixInterface.NativeFieldInfoPtr_Storage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateMixInterface>.NativeClassPtr, "Storage");
			CreateMixInterface.NativeFieldInfoPtr_ProductPropertiesLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateMixInterface>.NativeClassPtr, "ProductPropertiesLabel");
			CreateMixInterface.NativeFieldInfoPtr_OutputPropertiesLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateMixInterface>.NativeClassPtr, "OutputPropertiesLabel");
			CreateMixInterface.NativeFieldInfoPtr_BeanProblemLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateMixInterface>.NativeClassPtr, "BeanProblemLabel");
			CreateMixInterface.NativeFieldInfoPtr_ProductProblemLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateMixInterface>.NativeClassPtr, "ProductProblemLabel");
			CreateMixInterface.NativeFieldInfoPtr_MixerProblemLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateMixInterface>.NativeClassPtr, "MixerProblemLabel");
			CreateMixInterface.NativeFieldInfoPtr_OutputProblemLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateMixInterface>.NativeClassPtr, "OutputProblemLabel");
			CreateMixInterface.NativeFieldInfoPtr_CameraPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateMixInterface>.NativeClassPtr, "CameraPosition");
			CreateMixInterface.NativeFieldInfoPtr_UnknownOutputIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateMixInterface>.NativeClassPtr, "UnknownOutputIcon");
			CreateMixInterface.NativeFieldInfoPtr_onOpen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateMixInterface>.NativeClassPtr, "onOpen");
			CreateMixInterface.NativeFieldInfoPtr_onClose = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateMixInterface>.NativeClassPtr, "onClose");
			CreateMixInterface.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateMixInterface>.NativeClassPtr, 100680612);
			CreateMixInterface.NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateMixInterface>.NativeClassPtr, 100680613);
			CreateMixInterface.NativeMethodInfoPtr_get_beanSlot_Private_get_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateMixInterface>.NativeClassPtr, 100680614);
			CreateMixInterface.NativeMethodInfoPtr_get_mixerSlot_Private_get_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateMixInterface>.NativeClassPtr, 100680615);
			CreateMixInterface.NativeMethodInfoPtr_get_outputSlot_Private_get_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateMixInterface>.NativeClassPtr, 100680616);
			CreateMixInterface.NativeMethodInfoPtr_get_productSlot_Private_get_ItemSlot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateMixInterface>.NativeClassPtr, 100680617);
			CreateMixInterface.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateMixInterface>.NativeClassPtr, 100680618);
			CreateMixInterface.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateMixInterface>.NativeClassPtr, 100680619);
			CreateMixInterface.NativeMethodInfoPtr_Open_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateMixInterface>.NativeClassPtr, 100680620);
			CreateMixInterface.NativeMethodInfoPtr_ContentsChanged_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateMixInterface>.NativeClassPtr, 100680621);
			CreateMixInterface.NativeMethodInfoPtr_UpdateCanBegin_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateMixInterface>.NativeClassPtr, 100680622);
			CreateMixInterface.NativeMethodInfoPtr_UpdateOutput_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateMixInterface>.NativeClassPtr, 100680623);
			CreateMixInterface.NativeMethodInfoPtr_BeginPressed_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateMixInterface>.NativeClassPtr, 100680624);
			CreateMixInterface.NativeMethodInfoPtr_GetOutputProperties_Private_List_1_Property_ProductDefinition_PropertyItemDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateMixInterface>.NativeClassPtr, 100680625);
			CreateMixInterface.NativeMethodInfoPtr_IsOutputKnown_Private_Boolean_byref_ProductDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateMixInterface>.NativeClassPtr, 100680626);
			CreateMixInterface.NativeMethodInfoPtr_GetPropertyListString_Private_String_List_1_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateMixInterface>.NativeClassPtr, 100680627);
			CreateMixInterface.NativeMethodInfoPtr_GetPropertyString_Private_String_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateMixInterface>.NativeClassPtr, 100680628);
			CreateMixInterface.NativeMethodInfoPtr_CanBegin_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateMixInterface>.NativeClassPtr, 100680629);
			CreateMixInterface.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateMixInterface>.NativeClassPtr, 100680630);
			CreateMixInterface.NativeMethodInfoPtr_HasProduct_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateMixInterface>.NativeClassPtr, 100680631);
			CreateMixInterface.NativeMethodInfoPtr_HasBeans_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateMixInterface>.NativeClassPtr, 100680632);
			CreateMixInterface.NativeMethodInfoPtr_HasMixer_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateMixInterface>.NativeClassPtr, 100680633);
			CreateMixInterface.NativeMethodInfoPtr_GetProduct_Private_ProductDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateMixInterface>.NativeClassPtr, 100680634);
			CreateMixInterface.NativeMethodInfoPtr_GetMixer_Private_PropertyItemDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateMixInterface>.NativeClassPtr, 100680635);
			CreateMixInterface.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateMixInterface>.NativeClassPtr, 100680636);
		}

		// Token: 0x17002A90 RID: 10896
		// (get) Token: 0x06008B5D RID: 35677 RVA: 0x0024772C File Offset: 0x0024592C
		// (set) Token: 0x06008B5E RID: 35678 RVA: 0x00247768 File Offset: 0x00245968
		public unsafe bool IsOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateMixInterface.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateMixInterface.NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002A91 RID: 10897
		// (get) Token: 0x06008B5F RID: 35679 RVA: 0x002477A8 File Offset: 0x002459A8
		public unsafe ItemSlot beanSlot
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255041, XrefRangeEnd = 255045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateMixInterface.NativeMethodInfoPtr_get_beanSlot_Private_get_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemSlot>(intPtr3) : null;
			}
		}

		// Token: 0x17002A92 RID: 10898
		// (get) Token: 0x06008B60 RID: 35680 RVA: 0x002477E8 File Offset: 0x002459E8
		public unsafe ItemSlot mixerSlot
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255045, XrefRangeEnd = 255049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateMixInterface.NativeMethodInfoPtr_get_mixerSlot_Private_get_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemSlot>(intPtr3) : null;
			}
		}

		// Token: 0x17002A93 RID: 10899
		// (get) Token: 0x06008B61 RID: 35681 RVA: 0x00247828 File Offset: 0x00245A28
		public unsafe ItemSlot outputSlot
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255049, XrefRangeEnd = 255053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateMixInterface.NativeMethodInfoPtr_get_outputSlot_Private_get_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemSlot>(intPtr3) : null;
			}
		}

		// Token: 0x17002A94 RID: 10900
		// (get) Token: 0x06008B62 RID: 35682 RVA: 0x00247868 File Offset: 0x00245A68
		public unsafe ItemSlot productSlot
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255053, XrefRangeEnd = 255057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateMixInterface.NativeMethodInfoPtr_get_productSlot_Private_get_ItemSlot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemSlot>(intPtr3) : null;
			}
		}

		// Token: 0x06008B63 RID: 35683 RVA: 0x002478A8 File Offset: 0x00245AA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255057, XrefRangeEnd = 255141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CreateMixInterface.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008B64 RID: 35684 RVA: 0x002478E4 File Offset: 0x00245AE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255141, XrefRangeEnd = 255142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit(ExitAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateMixInterface.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008B65 RID: 35685 RVA: 0x00247928 File Offset: 0x00245B28
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 255240, RefRangeEnd = 255241, XrefRangeStart = 255142, XrefRangeEnd = 255240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateMixInterface.NativeMethodInfoPtr_Open_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008B66 RID: 35686 RVA: 0x0024795C File Offset: 0x00245B5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255241, XrefRangeEnd = 255243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ContentsChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateMixInterface.NativeMethodInfoPtr_ContentsChanged_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008B67 RID: 35687 RVA: 0x00247990 File Offset: 0x00245B90
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 255288, RefRangeEnd = 255290, XrefRangeStart = 255243, XrefRangeEnd = 255288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateCanBegin()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateMixInterface.NativeMethodInfoPtr_UpdateCanBegin_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008B68 RID: 35688 RVA: 0x002479C4 File Offset: 0x00245BC4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 255380, RefRangeEnd = 255382, XrefRangeStart = 255290, XrefRangeEnd = 255380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateOutput()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateMixInterface.NativeMethodInfoPtr_UpdateOutput_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008B69 RID: 35689 RVA: 0x002479F8 File Offset: 0x00245BF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255382, XrefRangeEnd = 255407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BeginPressed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateMixInterface.NativeMethodInfoPtr_BeginPressed_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008B6A RID: 35690 RVA: 0x00247A2C File Offset: 0x00245C2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255407, XrefRangeEnd = 255413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<Property> GetOutputProperties(ProductDefinition product, PropertyItemDefinition mixer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(product);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(mixer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateMixInterface.NativeMethodInfoPtr_GetOutputProperties_Private_List_1_Property_ProductDefinition_PropertyItemDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<Property>>(intPtr3) : null;
		}

		// Token: 0x06008B6B RID: 35691 RVA: 0x00247A90 File Offset: 0x00245C90
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 255440, RefRangeEnd = 255441, XrefRangeStart = 255413, XrefRangeEnd = 255440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsOutputKnown(out ProductDefinition knownProduct)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(CreateMixInterface.NativeMethodInfoPtr_IsOutputKnown_Private_Boolean_byref_ProductDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			knownProduct = ((intPtr4 == 0) ? null : new ProductDefinition(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06008B6C RID: 35692 RVA: 0x00247AF0 File Offset: 0x00245CF0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 255454, RefRangeEnd = 255456, XrefRangeStart = 255441, XrefRangeEnd = 255454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetPropertyListString(List<Property> properties)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(properties);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateMixInterface.NativeMethodInfoPtr_GetPropertyListString_Private_String_List_1_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06008B6D RID: 35693 RVA: 0x00247B38 File Offset: 0x00245D38
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 255474, RefRangeEnd = 255476, XrefRangeStart = 255456, XrefRangeEnd = 255474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetPropertyString(Property property)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(property);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateMixInterface.NativeMethodInfoPtr_GetPropertyString_Private_String_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06008B6E RID: 35694 RVA: 0x00247B80 File Offset: 0x00245D80
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 255491, RefRangeEnd = 255493, XrefRangeStart = 255476, XrefRangeEnd = 255491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanBegin()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateMixInterface.NativeMethodInfoPtr_CanBegin_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06008B6F RID: 35695 RVA: 0x00247BBC File Offset: 0x00245DBC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 255589, RefRangeEnd = 255591, XrefRangeStart = 255493, XrefRangeEnd = 255589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateMixInterface.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008B70 RID: 35696 RVA: 0x00247BF0 File Offset: 0x00245DF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255591, XrefRangeEnd = 255596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasProduct()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateMixInterface.NativeMethodInfoPtr_HasProduct_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06008B71 RID: 35697 RVA: 0x00247C2C File Offset: 0x00245E2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255596, XrefRangeEnd = 255600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasBeans()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateMixInterface.NativeMethodInfoPtr_HasBeans_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06008B72 RID: 35698 RVA: 0x00247C68 File Offset: 0x00245E68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255600, XrefRangeEnd = 255605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasMixer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateMixInterface.NativeMethodInfoPtr_HasMixer_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06008B73 RID: 35699 RVA: 0x00247CA4 File Offset: 0x00245EA4
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 255609, RefRangeEnd = 255616, XrefRangeStart = 255605, XrefRangeEnd = 255609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProductDefinition GetProduct()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateMixInterface.NativeMethodInfoPtr_GetProduct_Private_ProductDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ProductDefinition>(intPtr3) : null;
		}

		// Token: 0x06008B74 RID: 35700 RVA: 0x00247CE4 File Offset: 0x00245EE4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 255637, RefRangeEnd = 255643, XrefRangeStart = 255616, XrefRangeEnd = 255637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PropertyItemDefinition GetMixer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateMixInterface.NativeMethodInfoPtr_GetMixer_Private_PropertyItemDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PropertyItemDefinition>(intPtr3) : null;
		}

		// Token: 0x06008B75 RID: 35701 RVA: 0x00247D24 File Offset: 0x00245F24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255643, XrefRangeEnd = 255646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CreateMixInterface() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CreateMixInterface>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateMixInterface.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008B76 RID: 35702 RVA: 0x00042B81 File Offset: 0x00040D81
		public CreateMixInterface(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002A7C RID: 10876
		// (get) Token: 0x06008B77 RID: 35703 RVA: 0x00247D60 File Offset: 0x00245F60
		// (set) Token: 0x06008B78 RID: 35704 RVA: 0x00042B8A File Offset: 0x00040D8A
		public unsafe static int BEAN_REQUIREMENT
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(CreateMixInterface.NativeFieldInfoPtr_BEAN_REQUIREMENT, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CreateMixInterface.NativeFieldInfoPtr_BEAN_REQUIREMENT, (void*)(&value));
			}
		}

		// Token: 0x17002A7D RID: 10877
		// (get) Token: 0x06008B79 RID: 35705 RVA: 0x00247D7C File Offset: 0x00245F7C
		// (set) Token: 0x06008B7A RID: 35706 RVA: 0x00042B98 File Offset: 0x00040D98
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateMixInterface.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateMixInterface.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17002A7E RID: 10878
		// (get) Token: 0x06008B7B RID: 35707 RVA: 0x00247DA4 File Offset: 0x00245FA4
		// (set) Token: 0x06008B7C RID: 35708 RVA: 0x00042BB3 File Offset: 0x00040DB3
		public unsafe Canvas Canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateMixInterface.NativeFieldInfoPtr_Canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateMixInterface.NativeFieldInfoPtr_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A7F RID: 10879
		// (get) Token: 0x06008B7D RID: 35709 RVA: 0x00247DD4 File Offset: 0x00245FD4
		// (set) Token: 0x06008B7E RID: 35710 RVA: 0x00042BD2 File Offset: 0x00040DD2
		public unsafe ItemSlotUI BeansSlot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateMixInterface.NativeFieldInfoPtr_BeansSlot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlotUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateMixInterface.NativeFieldInfoPtr_BeansSlot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A80 RID: 10880
		// (get) Token: 0x06008B7F RID: 35711 RVA: 0x00247E04 File Offset: 0x00246004
		// (set) Token: 0x06008B80 RID: 35712 RVA: 0x00042BF1 File Offset: 0x00040DF1
		public unsafe ItemSlotUI ProductSlot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateMixInterface.NativeFieldInfoPtr_ProductSlot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlotUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateMixInterface.NativeFieldInfoPtr_ProductSlot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A81 RID: 10881
		// (get) Token: 0x06008B81 RID: 35713 RVA: 0x00247E34 File Offset: 0x00246034
		// (set) Token: 0x06008B82 RID: 35714 RVA: 0x00042C10 File Offset: 0x00040E10
		public unsafe ItemSlotUI MixerSlot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateMixInterface.NativeFieldInfoPtr_MixerSlot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlotUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateMixInterface.NativeFieldInfoPtr_MixerSlot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A82 RID: 10882
		// (get) Token: 0x06008B83 RID: 35715 RVA: 0x00247E64 File Offset: 0x00246064
		// (set) Token: 0x06008B84 RID: 35716 RVA: 0x00042C2F File Offset: 0x00040E2F
		public unsafe ItemSlotUI OutputSlot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateMixInterface.NativeFieldInfoPtr_OutputSlot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSlotUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateMixInterface.NativeFieldInfoPtr_OutputSlot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A83 RID: 10883
		// (get) Token: 0x06008B85 RID: 35717 RVA: 0x00247E94 File Offset: 0x00246094
		// (set) Token: 0x06008B86 RID: 35718 RVA: 0x00042C4E File Offset: 0x00040E4E
		public unsafe Image OutputIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateMixInterface.NativeFieldInfoPtr_OutputIcon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateMixInterface.NativeFieldInfoPtr_OutputIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A84 RID: 10884
		// (get) Token: 0x06008B87 RID: 35719 RVA: 0x00247EC4 File Offset: 0x002460C4
		// (set) Token: 0x06008B88 RID: 35720 RVA: 0x00042C6D File Offset: 0x00040E6D
		public unsafe Button BeginButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateMixInterface.NativeFieldInfoPtr_BeginButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateMixInterface.NativeFieldInfoPtr_BeginButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A85 RID: 10885
		// (get) Token: 0x06008B89 RID: 35721 RVA: 0x00247EF4 File Offset: 0x002460F4
		// (set) Token: 0x06008B8A RID: 35722 RVA: 0x00042C8C File Offset: 0x00040E8C
		public unsafe WorldStorageEntity Storage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateMixInterface.NativeFieldInfoPtr_Storage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorldStorageEntity>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateMixInterface.NativeFieldInfoPtr_Storage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A86 RID: 10886
		// (get) Token: 0x06008B8B RID: 35723 RVA: 0x00247F24 File Offset: 0x00246124
		// (set) Token: 0x06008B8C RID: 35724 RVA: 0x00042CAB File Offset: 0x00040EAB
		public unsafe TextMeshProUGUI ProductPropertiesLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateMixInterface.NativeFieldInfoPtr_ProductPropertiesLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateMixInterface.NativeFieldInfoPtr_ProductPropertiesLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A87 RID: 10887
		// (get) Token: 0x06008B8D RID: 35725 RVA: 0x00247F54 File Offset: 0x00246154
		// (set) Token: 0x06008B8E RID: 35726 RVA: 0x00042CCA File Offset: 0x00040ECA
		public unsafe TextMeshProUGUI OutputPropertiesLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateMixInterface.NativeFieldInfoPtr_OutputPropertiesLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateMixInterface.NativeFieldInfoPtr_OutputPropertiesLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A88 RID: 10888
		// (get) Token: 0x06008B8F RID: 35727 RVA: 0x00247F84 File Offset: 0x00246184
		// (set) Token: 0x06008B90 RID: 35728 RVA: 0x00042CE9 File Offset: 0x00040EE9
		public unsafe TextMeshProUGUI BeanProblemLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateMixInterface.NativeFieldInfoPtr_BeanProblemLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateMixInterface.NativeFieldInfoPtr_BeanProblemLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A89 RID: 10889
		// (get) Token: 0x06008B91 RID: 35729 RVA: 0x00247FB4 File Offset: 0x002461B4
		// (set) Token: 0x06008B92 RID: 35730 RVA: 0x00042D08 File Offset: 0x00040F08
		public unsafe TextMeshProUGUI ProductProblemLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateMixInterface.NativeFieldInfoPtr_ProductProblemLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateMixInterface.NativeFieldInfoPtr_ProductProblemLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A8A RID: 10890
		// (get) Token: 0x06008B93 RID: 35731 RVA: 0x00247FE4 File Offset: 0x002461E4
		// (set) Token: 0x06008B94 RID: 35732 RVA: 0x00042D27 File Offset: 0x00040F27
		public unsafe TextMeshProUGUI MixerProblemLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateMixInterface.NativeFieldInfoPtr_MixerProblemLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateMixInterface.NativeFieldInfoPtr_MixerProblemLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A8B RID: 10891
		// (get) Token: 0x06008B95 RID: 35733 RVA: 0x00248014 File Offset: 0x00246214
		// (set) Token: 0x06008B96 RID: 35734 RVA: 0x00042D46 File Offset: 0x00040F46
		public unsafe TextMeshProUGUI OutputProblemLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateMixInterface.NativeFieldInfoPtr_OutputProblemLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateMixInterface.NativeFieldInfoPtr_OutputProblemLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A8C RID: 10892
		// (get) Token: 0x06008B97 RID: 35735 RVA: 0x00248044 File Offset: 0x00246244
		// (set) Token: 0x06008B98 RID: 35736 RVA: 0x00042D65 File Offset: 0x00040F65
		public unsafe Transform CameraPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateMixInterface.NativeFieldInfoPtr_CameraPosition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateMixInterface.NativeFieldInfoPtr_CameraPosition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A8D RID: 10893
		// (get) Token: 0x06008B99 RID: 35737 RVA: 0x00248074 File Offset: 0x00246274
		// (set) Token: 0x06008B9A RID: 35738 RVA: 0x00042D84 File Offset: 0x00040F84
		public unsafe RectTransform UnknownOutputIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateMixInterface.NativeFieldInfoPtr_UnknownOutputIcon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateMixInterface.NativeFieldInfoPtr_UnknownOutputIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A8E RID: 10894
		// (get) Token: 0x06008B9B RID: 35739 RVA: 0x002480A4 File Offset: 0x002462A4
		// (set) Token: 0x06008B9C RID: 35740 RVA: 0x00042DA3 File Offset: 0x00040FA3
		public unsafe UnityEvent onOpen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateMixInterface.NativeFieldInfoPtr_onOpen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateMixInterface.NativeFieldInfoPtr_onOpen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A8F RID: 10895
		// (get) Token: 0x06008B9D RID: 35741 RVA: 0x002480D4 File Offset: 0x002462D4
		// (set) Token: 0x06008B9E RID: 35742 RVA: 0x00042DC2 File Offset: 0x00040FC2
		public unsafe UnityEvent onClose
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateMixInterface.NativeFieldInfoPtr_onClose);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreateMixInterface.NativeFieldInfoPtr_onClose), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005E7D RID: 24189
		private static readonly IntPtr NativeFieldInfoPtr_BEAN_REQUIREMENT;

		// Token: 0x04005E7E RID: 24190
		private static readonly IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x04005E7F RID: 24191
		private static readonly IntPtr NativeFieldInfoPtr_Canvas;

		// Token: 0x04005E80 RID: 24192
		private static readonly IntPtr NativeFieldInfoPtr_BeansSlot;

		// Token: 0x04005E81 RID: 24193
		private static readonly IntPtr NativeFieldInfoPtr_ProductSlot;

		// Token: 0x04005E82 RID: 24194
		private static readonly IntPtr NativeFieldInfoPtr_MixerSlot;

		// Token: 0x04005E83 RID: 24195
		private static readonly IntPtr NativeFieldInfoPtr_OutputSlot;

		// Token: 0x04005E84 RID: 24196
		private static readonly IntPtr NativeFieldInfoPtr_OutputIcon;

		// Token: 0x04005E85 RID: 24197
		private static readonly IntPtr NativeFieldInfoPtr_BeginButton;

		// Token: 0x04005E86 RID: 24198
		private static readonly IntPtr NativeFieldInfoPtr_Storage;

		// Token: 0x04005E87 RID: 24199
		private static readonly IntPtr NativeFieldInfoPtr_ProductPropertiesLabel;

		// Token: 0x04005E88 RID: 24200
		private static readonly IntPtr NativeFieldInfoPtr_OutputPropertiesLabel;

		// Token: 0x04005E89 RID: 24201
		private static readonly IntPtr NativeFieldInfoPtr_BeanProblemLabel;

		// Token: 0x04005E8A RID: 24202
		private static readonly IntPtr NativeFieldInfoPtr_ProductProblemLabel;

		// Token: 0x04005E8B RID: 24203
		private static readonly IntPtr NativeFieldInfoPtr_MixerProblemLabel;

		// Token: 0x04005E8C RID: 24204
		private static readonly IntPtr NativeFieldInfoPtr_OutputProblemLabel;

		// Token: 0x04005E8D RID: 24205
		private static readonly IntPtr NativeFieldInfoPtr_CameraPosition;

		// Token: 0x04005E8E RID: 24206
		private static readonly IntPtr NativeFieldInfoPtr_UnknownOutputIcon;

		// Token: 0x04005E8F RID: 24207
		private static readonly IntPtr NativeFieldInfoPtr_onOpen;

		// Token: 0x04005E90 RID: 24208
		private static readonly IntPtr NativeFieldInfoPtr_onClose;

		// Token: 0x04005E91 RID: 24209
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x04005E92 RID: 24210
		private static readonly IntPtr NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0;

		// Token: 0x04005E93 RID: 24211
		private static readonly IntPtr NativeMethodInfoPtr_get_beanSlot_Private_get_ItemSlot_0;

		// Token: 0x04005E94 RID: 24212
		private static readonly IntPtr NativeMethodInfoPtr_get_mixerSlot_Private_get_ItemSlot_0;

		// Token: 0x04005E95 RID: 24213
		private static readonly IntPtr NativeMethodInfoPtr_get_outputSlot_Private_get_ItemSlot_0;

		// Token: 0x04005E96 RID: 24214
		private static readonly IntPtr NativeMethodInfoPtr_get_productSlot_Private_get_ItemSlot_0;

		// Token: 0x04005E97 RID: 24215
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04005E98 RID: 24216
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0;

		// Token: 0x04005E99 RID: 24217
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Void_0;

		// Token: 0x04005E9A RID: 24218
		private static readonly IntPtr NativeMethodInfoPtr_ContentsChanged_Private_Void_0;

		// Token: 0x04005E9B RID: 24219
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCanBegin_Private_Void_0;

		// Token: 0x04005E9C RID: 24220
		private static readonly IntPtr NativeMethodInfoPtr_UpdateOutput_Private_Void_0;

		// Token: 0x04005E9D RID: 24221
		private static readonly IntPtr NativeMethodInfoPtr_BeginPressed_Private_Void_0;

		// Token: 0x04005E9E RID: 24222
		private static readonly IntPtr NativeMethodInfoPtr_GetOutputProperties_Private_List_1_Property_ProductDefinition_PropertyItemDefinition_0;

		// Token: 0x04005E9F RID: 24223
		private static readonly IntPtr NativeMethodInfoPtr_IsOutputKnown_Private_Boolean_byref_ProductDefinition_0;

		// Token: 0x04005EA0 RID: 24224
		private static readonly IntPtr NativeMethodInfoPtr_GetPropertyListString_Private_String_List_1_Property_0;

		// Token: 0x04005EA1 RID: 24225
		private static readonly IntPtr NativeMethodInfoPtr_GetPropertyString_Private_String_Property_0;

		// Token: 0x04005EA2 RID: 24226
		private static readonly IntPtr NativeMethodInfoPtr_CanBegin_Private_Boolean_0;

		// Token: 0x04005EA3 RID: 24227
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x04005EA4 RID: 24228
		private static readonly IntPtr NativeMethodInfoPtr_HasProduct_Private_Boolean_0;

		// Token: 0x04005EA5 RID: 24229
		private static readonly IntPtr NativeMethodInfoPtr_HasBeans_Private_Boolean_0;

		// Token: 0x04005EA6 RID: 24230
		private static readonly IntPtr NativeMethodInfoPtr_HasMixer_Private_Boolean_0;

		// Token: 0x04005EA7 RID: 24231
		private static readonly IntPtr NativeMethodInfoPtr_GetProduct_Private_ProductDefinition_0;

		// Token: 0x04005EA8 RID: 24232
		private static readonly IntPtr NativeMethodInfoPtr_GetMixer_Private_PropertyItemDefinition_0;

		// Token: 0x04005EA9 RID: 24233
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
