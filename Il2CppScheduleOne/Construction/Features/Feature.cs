using System;
using Il2CppFishNet.Object;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.UI.Construction.Features;
using UnityEngine;

namespace Il2CppScheduleOne.Construction.Features
{
	// Token: 0x02000482 RID: 1154
	public class Feature : NetworkBehaviour
	{
		// Token: 0x0600641E RID: 25630 RVA: 0x001C5570 File Offset: 0x001C3770
		// Note: this type is marked as 'beforefieldinit'.
		static Feature()
		{
			Il2CppClassPointerStore<Feature>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Construction.Features", "Feature");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Feature>.NativeClassPtr);
			Feature.NativeFieldInfoPtr_featureName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Feature>.NativeClassPtr, "featureName");
			Feature.NativeFieldInfoPtr_featureIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Feature>.NativeClassPtr, "featureIcon");
			Feature.NativeFieldInfoPtr_featureIconLocation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Feature>.NativeClassPtr, "featureIconLocation");
			Feature.NativeFieldInfoPtr_featureInterfacePrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Feature>.NativeClassPtr, "featureInterfacePrefab");
			Feature.NativeFieldInfoPtr_disableRoofDisibility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Feature>.NativeClassPtr, "disableRoofDisibility");
			Feature.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Feature>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Construction.Features.FeatureAssembly-CSharp.dll_Excuted");
			Feature.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Feature>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Construction.Features.FeatureAssembly-CSharp.dll_Excuted");
			Feature.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Feature>.NativeClassPtr, 100675991);
			Feature.NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Feature>.NativeClassPtr, 100675992);
			Feature.NativeMethodInfoPtr_CreateInterface_Public_Virtual_New_FI_Base_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Feature>.NativeClassPtr, 100675993);
			Feature.NativeMethodInfoPtr_Default_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Feature>.NativeClassPtr, 100675994);
			Feature.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Feature>.NativeClassPtr, 100675995);
			Feature.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Feature>.NativeClassPtr, 100675996);
			Feature.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Feature>.NativeClassPtr, 100675997);
			Feature.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Feature>.NativeClassPtr, 100675998);
			Feature.NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Feature>.NativeClassPtr, 100675999);
		}

		// Token: 0x0600641F RID: 25631 RVA: 0x001C56E0 File Offset: 0x001C38E0
		[CallerCount(0)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Feature.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006420 RID: 25632 RVA: 0x001C571C File Offset: 0x001C391C
		[CallerCount(2259)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnStartClient()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Feature.NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006421 RID: 25633 RVA: 0x001C5758 File Offset: 0x001C3958
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204044, XrefRangeEnd = 204053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual FI_Base CreateInterface(Transform parent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Feature.NativeMethodInfoPtr_CreateInterface_Public_Virtual_New_FI_Base_Transform_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<FI_Base>(intPtr3) : null;
		}

		// Token: 0x06006422 RID: 25634 RVA: 0x001C57B4 File Offset: 0x001C39B4
		[CallerCount(0)]
		public unsafe virtual void Default()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Feature.NativeMethodInfoPtr_Default_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006423 RID: 25635 RVA: 0x001C57F0 File Offset: 0x001C39F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204053, XrefRangeEnd = 204058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Feature() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Feature>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Feature.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006424 RID: 25636 RVA: 0x001C582C File Offset: 0x001C3A2C
		[CallerCount(0)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Feature.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006425 RID: 25637 RVA: 0x001C5868 File Offset: 0x001C3A68
		[CallerCount(0)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Feature.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006426 RID: 25638 RVA: 0x001C58A4 File Offset: 0x001C3AA4
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Feature.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006427 RID: 25639 RVA: 0x001C58E0 File Offset: 0x001C3AE0
		[CallerCount(13604)]
		[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Method_Protected_Virtual_New_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Feature.NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006428 RID: 25640 RVA: 0x0002F570 File Offset: 0x0002D770
		public Feature(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001E30 RID: 7728
		// (get) Token: 0x06006429 RID: 25641 RVA: 0x001C591C File Offset: 0x001C3B1C
		// (set) Token: 0x0600642A RID: 25642 RVA: 0x0002F579 File Offset: 0x0002D779
		public unsafe string featureName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Feature.NativeFieldInfoPtr_featureName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Feature.NativeFieldInfoPtr_featureName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001E31 RID: 7729
		// (get) Token: 0x0600642B RID: 25643 RVA: 0x001C5944 File Offset: 0x001C3B44
		// (set) Token: 0x0600642C RID: 25644 RVA: 0x0002F598 File Offset: 0x0002D798
		public unsafe Sprite featureIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Feature.NativeFieldInfoPtr_featureIcon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Feature.NativeFieldInfoPtr_featureIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E32 RID: 7730
		// (get) Token: 0x0600642D RID: 25645 RVA: 0x001C5974 File Offset: 0x001C3B74
		// (set) Token: 0x0600642E RID: 25646 RVA: 0x0002F5B7 File Offset: 0x0002D7B7
		public unsafe Transform featureIconLocation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Feature.NativeFieldInfoPtr_featureIconLocation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Feature.NativeFieldInfoPtr_featureIconLocation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E33 RID: 7731
		// (get) Token: 0x0600642F RID: 25647 RVA: 0x001C59A4 File Offset: 0x001C3BA4
		// (set) Token: 0x06006430 RID: 25648 RVA: 0x0002F5D6 File Offset: 0x0002D7D6
		public unsafe GameObject featureInterfacePrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Feature.NativeFieldInfoPtr_featureInterfacePrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Feature.NativeFieldInfoPtr_featureInterfacePrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E34 RID: 7732
		// (get) Token: 0x06006431 RID: 25649 RVA: 0x001C59D4 File Offset: 0x001C3BD4
		// (set) Token: 0x06006432 RID: 25650 RVA: 0x0002F5F5 File Offset: 0x0002D7F5
		public unsafe bool disableRoofDisibility
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Feature.NativeFieldInfoPtr_disableRoofDisibility);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Feature.NativeFieldInfoPtr_disableRoofDisibility)) = value;
			}
		}

		// Token: 0x17001E35 RID: 7733
		// (get) Token: 0x06006433 RID: 25651 RVA: 0x001C59FC File Offset: 0x001C3BFC
		// (set) Token: 0x06006434 RID: 25652 RVA: 0x0002F610 File Offset: 0x0002D810
		public unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Feature.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Feature.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17001E36 RID: 7734
		// (get) Token: 0x06006435 RID: 25653 RVA: 0x001C5A24 File Offset: 0x001C3C24
		// (set) Token: 0x06006436 RID: 25654 RVA: 0x0002F62B File Offset: 0x0002D82B
		public unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Feature.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Feature.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04004454 RID: 17492
		private static readonly IntPtr NativeFieldInfoPtr_featureName;

		// Token: 0x04004455 RID: 17493
		private static readonly IntPtr NativeFieldInfoPtr_featureIcon;

		// Token: 0x04004456 RID: 17494
		private static readonly IntPtr NativeFieldInfoPtr_featureIconLocation;

		// Token: 0x04004457 RID: 17495
		private static readonly IntPtr NativeFieldInfoPtr_featureInterfacePrefab;

		// Token: 0x04004458 RID: 17496
		private static readonly IntPtr NativeFieldInfoPtr_disableRoofDisibility;

		// Token: 0x04004459 RID: 17497
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x0400445A RID: 17498
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x0400445B RID: 17499
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x0400445C RID: 17500
		private static readonly IntPtr NativeMethodInfoPtr_OnStartClient_Public_Virtual_Void_0;

		// Token: 0x0400445D RID: 17501
		private static readonly IntPtr NativeMethodInfoPtr_CreateInterface_Public_Virtual_New_FI_Base_Transform_0;

		// Token: 0x0400445E RID: 17502
		private static readonly IntPtr NativeMethodInfoPtr_Default_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x0400445F RID: 17503
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04004460 RID: 17504
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04004461 RID: 17505
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04004462 RID: 17506
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04004463 RID: 17507
		private static readonly IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_New_Void_0;
	}
}
