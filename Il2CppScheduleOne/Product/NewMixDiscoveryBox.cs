using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Interaction;
using Il2CppScheduleOne.Packaging;
using Il2CppScheduleOne.Properties;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;

namespace Il2CppScheduleOne.Product
{
	// Token: 0x020005A3 RID: 1443
	public class NewMixDiscoveryBox : MonoBehaviour
	{
		// Token: 0x06007E1C RID: 32284 RVA: 0x0021BFAC File Offset: 0x0021A1AC
		// Note: this type is marked as 'beforefieldinit'.
		static NewMixDiscoveryBox()
		{
			Il2CppClassPointerStore<NewMixDiscoveryBox>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Product", "NewMixDiscoveryBox");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NewMixDiscoveryBox>.NativeClassPtr);
			NewMixDiscoveryBox.NativeFieldInfoPtr_isOpen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewMixDiscoveryBox>.NativeClassPtr, "isOpen");
			NewMixDiscoveryBox.NativeFieldInfoPtr_CameraPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewMixDiscoveryBox>.NativeClassPtr, "CameraPosition");
			NewMixDiscoveryBox.NativeFieldInfoPtr_PropertiesText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewMixDiscoveryBox>.NativeClassPtr, "PropertiesText");
			NewMixDiscoveryBox.NativeFieldInfoPtr_Visuals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewMixDiscoveryBox>.NativeClassPtr, "Visuals");
			NewMixDiscoveryBox.NativeFieldInfoPtr_Animation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewMixDiscoveryBox>.NativeClassPtr, "Animation");
			NewMixDiscoveryBox.NativeFieldInfoPtr_IntObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewMixDiscoveryBox>.NativeClassPtr, "IntObj");
			NewMixDiscoveryBox.NativeFieldInfoPtr_Lid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewMixDiscoveryBox>.NativeClassPtr, "Lid");
			NewMixDiscoveryBox.NativeFieldInfoPtr_closedLidPose = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewMixDiscoveryBox>.NativeClassPtr, "closedLidPose");
			NewMixDiscoveryBox.NativeFieldInfoPtr_currentMix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewMixDiscoveryBox>.NativeClassPtr, "currentMix");
			NewMixDiscoveryBox.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewMixDiscoveryBox>.NativeClassPtr, 100679067);
			NewMixDiscoveryBox.NativeMethodInfoPtr_ShowProduct_Public_Void_ProductDefinition_List_1_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewMixDiscoveryBox>.NativeClassPtr, 100679068);
			NewMixDiscoveryBox.NativeMethodInfoPtr_CloseCase_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewMixDiscoveryBox>.NativeClassPtr, 100679069);
			NewMixDiscoveryBox.NativeMethodInfoPtr_OpenCase_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewMixDiscoveryBox>.NativeClassPtr, 100679070);
			NewMixDiscoveryBox.NativeMethodInfoPtr_Interacted_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewMixDiscoveryBox>.NativeClassPtr, 100679071);
			NewMixDiscoveryBox.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewMixDiscoveryBox>.NativeClassPtr, 100679072);
		}

		// Token: 0x06007E1D RID: 32285 RVA: 0x0021C108 File Offset: 0x0021A308
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238654, XrefRangeEnd = 238672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewMixDiscoveryBox.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007E1E RID: 32286 RVA: 0x0021C13C File Offset: 0x0021A33C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 238880, RefRangeEnd = 238882, XrefRangeStart = 238672, XrefRangeEnd = 238880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowProduct(ProductDefinition baseDefinition, List<Property> properties)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(baseDefinition);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(properties);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewMixDiscoveryBox.NativeMethodInfoPtr_ShowProduct_Public_Void_ProductDefinition_List_1_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007E1F RID: 32287 RVA: 0x0021C190 File Offset: 0x0021A390
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238882, XrefRangeEnd = 238884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CloseCase()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewMixDiscoveryBox.NativeMethodInfoPtr_CloseCase_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007E20 RID: 32288 RVA: 0x0021C1C4 File Offset: 0x0021A3C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238884, XrefRangeEnd = 238888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenCase()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewMixDiscoveryBox.NativeMethodInfoPtr_OpenCase_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007E21 RID: 32289 RVA: 0x0021C1F8 File Offset: 0x0021A3F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238888, XrefRangeEnd = 238893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Interacted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewMixDiscoveryBox.NativeMethodInfoPtr_Interacted_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007E22 RID: 32290 RVA: 0x0021C22C File Offset: 0x0021A42C
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NewMixDiscoveryBox() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NewMixDiscoveryBox>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewMixDiscoveryBox.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007E23 RID: 32291 RVA: 0x0003BE9D File Offset: 0x0003A09D
		public NewMixDiscoveryBox(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002623 RID: 9763
		// (get) Token: 0x06007E24 RID: 32292 RVA: 0x0021C268 File Offset: 0x0021A468
		// (set) Token: 0x06007E25 RID: 32293 RVA: 0x0003BEA6 File Offset: 0x0003A0A6
		public unsafe bool isOpen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixDiscoveryBox.NativeFieldInfoPtr_isOpen);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixDiscoveryBox.NativeFieldInfoPtr_isOpen)) = value;
			}
		}

		// Token: 0x17002624 RID: 9764
		// (get) Token: 0x06007E26 RID: 32294 RVA: 0x0021C290 File Offset: 0x0021A490
		// (set) Token: 0x06007E27 RID: 32295 RVA: 0x0003BEC1 File Offset: 0x0003A0C1
		public unsafe Transform CameraPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixDiscoveryBox.NativeFieldInfoPtr_CameraPosition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixDiscoveryBox.NativeFieldInfoPtr_CameraPosition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002625 RID: 9765
		// (get) Token: 0x06007E28 RID: 32296 RVA: 0x0021C2C0 File Offset: 0x0021A4C0
		// (set) Token: 0x06007E29 RID: 32297 RVA: 0x0003BEE0 File Offset: 0x0003A0E0
		public unsafe TextMeshPro PropertiesText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixDiscoveryBox.NativeFieldInfoPtr_PropertiesText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshPro>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixDiscoveryBox.NativeFieldInfoPtr_PropertiesText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002626 RID: 9766
		// (get) Token: 0x06007E2A RID: 32298 RVA: 0x0021C2F0 File Offset: 0x0021A4F0
		// (set) Token: 0x06007E2B RID: 32299 RVA: 0x0003BEFF File Offset: 0x0003A0FF
		public unsafe Il2CppReferenceArray<NewMixDiscoveryBox.DrugTypeVisuals> Visuals
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixDiscoveryBox.NativeFieldInfoPtr_Visuals);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<NewMixDiscoveryBox.DrugTypeVisuals>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixDiscoveryBox.NativeFieldInfoPtr_Visuals), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002627 RID: 9767
		// (get) Token: 0x06007E2C RID: 32300 RVA: 0x0021C320 File Offset: 0x0021A520
		// (set) Token: 0x06007E2D RID: 32301 RVA: 0x0003BF1E File Offset: 0x0003A11E
		public unsafe Animation Animation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixDiscoveryBox.NativeFieldInfoPtr_Animation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixDiscoveryBox.NativeFieldInfoPtr_Animation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002628 RID: 9768
		// (get) Token: 0x06007E2E RID: 32302 RVA: 0x0021C350 File Offset: 0x0021A550
		// (set) Token: 0x06007E2F RID: 32303 RVA: 0x0003BF3D File Offset: 0x0003A13D
		public unsafe InteractableObject IntObj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixDiscoveryBox.NativeFieldInfoPtr_IntObj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractableObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixDiscoveryBox.NativeFieldInfoPtr_IntObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002629 RID: 9769
		// (get) Token: 0x06007E30 RID: 32304 RVA: 0x0021C380 File Offset: 0x0021A580
		// (set) Token: 0x06007E31 RID: 32305 RVA: 0x0003BF5C File Offset: 0x0003A15C
		public unsafe Transform Lid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixDiscoveryBox.NativeFieldInfoPtr_Lid);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixDiscoveryBox.NativeFieldInfoPtr_Lid), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700262A RID: 9770
		// (get) Token: 0x06007E32 RID: 32306 RVA: 0x0021C3B0 File Offset: 0x0021A5B0
		// (set) Token: 0x06007E33 RID: 32307 RVA: 0x0003BF7B File Offset: 0x0003A17B
		public unsafe Pose closedLidPose
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixDiscoveryBox.NativeFieldInfoPtr_closedLidPose);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixDiscoveryBox.NativeFieldInfoPtr_closedLidPose)) = value;
			}
		}

		// Token: 0x1700262B RID: 9771
		// (get) Token: 0x06007E34 RID: 32308 RVA: 0x0021C3D8 File Offset: 0x0021A5D8
		// (set) Token: 0x06007E35 RID: 32309 RVA: 0x0003BF96 File Offset: 0x0003A196
		public unsafe NewMixOperation currentMix
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixDiscoveryBox.NativeFieldInfoPtr_currentMix);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NewMixOperation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixDiscoveryBox.NativeFieldInfoPtr_currentMix), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040055D5 RID: 21973
		private static readonly IntPtr NativeFieldInfoPtr_isOpen;

		// Token: 0x040055D6 RID: 21974
		private static readonly IntPtr NativeFieldInfoPtr_CameraPosition;

		// Token: 0x040055D7 RID: 21975
		private static readonly IntPtr NativeFieldInfoPtr_PropertiesText;

		// Token: 0x040055D8 RID: 21976
		private static readonly IntPtr NativeFieldInfoPtr_Visuals;

		// Token: 0x040055D9 RID: 21977
		private static readonly IntPtr NativeFieldInfoPtr_Animation;

		// Token: 0x040055DA RID: 21978
		private static readonly IntPtr NativeFieldInfoPtr_IntObj;

		// Token: 0x040055DB RID: 21979
		private static readonly IntPtr NativeFieldInfoPtr_Lid;

		// Token: 0x040055DC RID: 21980
		private static readonly IntPtr NativeFieldInfoPtr_closedLidPose;

		// Token: 0x040055DD RID: 21981
		private static readonly IntPtr NativeFieldInfoPtr_currentMix;

		// Token: 0x040055DE RID: 21982
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x040055DF RID: 21983
		private static readonly IntPtr NativeMethodInfoPtr_ShowProduct_Public_Void_ProductDefinition_List_1_Property_0;

		// Token: 0x040055E0 RID: 21984
		private static readonly IntPtr NativeMethodInfoPtr_CloseCase_Private_Void_0;

		// Token: 0x040055E1 RID: 21985
		private static readonly IntPtr NativeMethodInfoPtr_OpenCase_Private_Void_0;

		// Token: 0x040055E2 RID: 21986
		private static readonly IntPtr NativeMethodInfoPtr_Interacted_Private_Void_0;

		// Token: 0x040055E3 RID: 21987
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000AC6 RID: 2758
		[Serializable]
		public class DrugTypeVisuals : Il2CppSystem.Object
		{
			// Token: 0x0600D417 RID: 54295 RVA: 0x0032A0E4 File Offset: 0x003282E4
			// Note: this type is marked as 'beforefieldinit'.
			static DrugTypeVisuals()
			{
				Il2CppClassPointerStore<NewMixDiscoveryBox.DrugTypeVisuals>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NewMixDiscoveryBox>.NativeClassPtr, "DrugTypeVisuals");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NewMixDiscoveryBox.DrugTypeVisuals>.NativeClassPtr);
				NewMixDiscoveryBox.DrugTypeVisuals.NativeFieldInfoPtr_DrugType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewMixDiscoveryBox.DrugTypeVisuals>.NativeClassPtr, "DrugType");
				NewMixDiscoveryBox.DrugTypeVisuals.NativeFieldInfoPtr_Visuals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewMixDiscoveryBox.DrugTypeVisuals>.NativeClassPtr, "Visuals");
				NewMixDiscoveryBox.DrugTypeVisuals.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewMixDiscoveryBox.DrugTypeVisuals>.NativeClassPtr, 100679073);
			}

			// Token: 0x0600D418 RID: 54296 RVA: 0x0032A14C File Offset: 0x0032834C
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DrugTypeVisuals() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NewMixDiscoveryBox.DrugTypeVisuals>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewMixDiscoveryBox.DrugTypeVisuals.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D419 RID: 54297 RVA: 0x0006739B File Offset: 0x0006559B
			public DrugTypeVisuals(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170041C0 RID: 16832
			// (get) Token: 0x0600D41A RID: 54298 RVA: 0x0032A188 File Offset: 0x00328388
			// (set) Token: 0x0600D41B RID: 54299 RVA: 0x000673A4 File Offset: 0x000655A4
			public unsafe EDrugType DrugType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixDiscoveryBox.DrugTypeVisuals.NativeFieldInfoPtr_DrugType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixDiscoveryBox.DrugTypeVisuals.NativeFieldInfoPtr_DrugType)) = value;
				}
			}

			// Token: 0x170041C1 RID: 16833
			// (get) Token: 0x0600D41C RID: 54300 RVA: 0x0032A1B0 File Offset: 0x003283B0
			// (set) Token: 0x0600D41D RID: 54301 RVA: 0x000673BF File Offset: 0x000655BF
			public unsafe FilledPackagingVisuals Visuals
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixDiscoveryBox.DrugTypeVisuals.NativeFieldInfoPtr_Visuals);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FilledPackagingVisuals>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewMixDiscoveryBox.DrugTypeVisuals.NativeFieldInfoPtr_Visuals), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008ED0 RID: 36560
			private static readonly IntPtr NativeFieldInfoPtr_DrugType;

			// Token: 0x04008ED1 RID: 36561
			private static readonly IntPtr NativeFieldInfoPtr_Visuals;

			// Token: 0x04008ED2 RID: 36562
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000AC7 RID: 2759
		[ObfuscatedName("ScheduleOne.Product.NewMixDiscoveryBox+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600D41E RID: 54302 RVA: 0x0032A1E0 File Offset: 0x003283E0
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<NewMixDiscoveryBox.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NewMixDiscoveryBox>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NewMixDiscoveryBox.__c>.NativeClassPtr);
				NewMixDiscoveryBox.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewMixDiscoveryBox.__c>.NativeClassPtr, "<>9");
				NewMixDiscoveryBox.__c.NativeFieldInfoPtr___9__11_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewMixDiscoveryBox.__c>.NativeClassPtr, "<>9__11_0");
				NewMixDiscoveryBox.__c.NativeFieldInfoPtr___9__11_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewMixDiscoveryBox.__c>.NativeClassPtr, "<>9__11_1");
				NewMixDiscoveryBox.__c.NativeFieldInfoPtr___9__11_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewMixDiscoveryBox.__c>.NativeClassPtr, "<>9__11_2");
				NewMixDiscoveryBox.__c.NativeFieldInfoPtr___9__11_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewMixDiscoveryBox.__c>.NativeClassPtr, "<>9__11_3");
				NewMixDiscoveryBox.__c.NativeFieldInfoPtr___9__11_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewMixDiscoveryBox.__c>.NativeClassPtr, "<>9__11_4");
				NewMixDiscoveryBox.__c.NativeFieldInfoPtr___9__11_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewMixDiscoveryBox.__c>.NativeClassPtr, "<>9__11_5");
				NewMixDiscoveryBox.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewMixDiscoveryBox.__c>.NativeClassPtr, 100679075);
				NewMixDiscoveryBox.__c.NativeMethodInfoPtr__ShowProduct_b__11_0_Internal_Boolean_DrugTypeVisuals_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewMixDiscoveryBox.__c>.NativeClassPtr, 100679076);
				NewMixDiscoveryBox.__c.NativeMethodInfoPtr__ShowProduct_b__11_1_Internal_Boolean_DrugTypeVisuals_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewMixDiscoveryBox.__c>.NativeClassPtr, 100679077);
				NewMixDiscoveryBox.__c.NativeMethodInfoPtr__ShowProduct_b__11_2_Internal_Boolean_DrugTypeVisuals_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewMixDiscoveryBox.__c>.NativeClassPtr, 100679078);
				NewMixDiscoveryBox.__c.NativeMethodInfoPtr__ShowProduct_b__11_3_Internal_Boolean_DrugTypeVisuals_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewMixDiscoveryBox.__c>.NativeClassPtr, 100679079);
				NewMixDiscoveryBox.__c.NativeMethodInfoPtr__ShowProduct_b__11_4_Internal_Boolean_DrugTypeVisuals_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewMixDiscoveryBox.__c>.NativeClassPtr, 100679080);
				NewMixDiscoveryBox.__c.NativeMethodInfoPtr__ShowProduct_b__11_5_Internal_Boolean_DrugTypeVisuals_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewMixDiscoveryBox.__c>.NativeClassPtr, 100679081);
			}

			// Token: 0x0600D41F RID: 54303 RVA: 0x0032A324 File Offset: 0x00328524
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NewMixDiscoveryBox.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewMixDiscoveryBox.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D420 RID: 54304 RVA: 0x0032A360 File Offset: 0x00328560
			[CallerCount(0)]
			public unsafe bool _ShowProduct_b__11_0(NewMixDiscoveryBox.DrugTypeVisuals x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewMixDiscoveryBox.__c.NativeMethodInfoPtr__ShowProduct_b__11_0_Internal_Boolean_DrugTypeVisuals_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D421 RID: 54305 RVA: 0x0032A3B0 File Offset: 0x003285B0
			[CallerCount(0)]
			public unsafe bool _ShowProduct_b__11_1(NewMixDiscoveryBox.DrugTypeVisuals x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewMixDiscoveryBox.__c.NativeMethodInfoPtr__ShowProduct_b__11_1_Internal_Boolean_DrugTypeVisuals_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D422 RID: 54306 RVA: 0x0032A400 File Offset: 0x00328600
			[CallerCount(0)]
			public unsafe bool _ShowProduct_b__11_2(NewMixDiscoveryBox.DrugTypeVisuals x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewMixDiscoveryBox.__c.NativeMethodInfoPtr__ShowProduct_b__11_2_Internal_Boolean_DrugTypeVisuals_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D423 RID: 54307 RVA: 0x0032A450 File Offset: 0x00328650
			[CallerCount(0)]
			public unsafe bool _ShowProduct_b__11_3(NewMixDiscoveryBox.DrugTypeVisuals x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewMixDiscoveryBox.__c.NativeMethodInfoPtr__ShowProduct_b__11_3_Internal_Boolean_DrugTypeVisuals_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D424 RID: 54308 RVA: 0x0032A4A0 File Offset: 0x003286A0
			[CallerCount(0)]
			public unsafe bool _ShowProduct_b__11_4(NewMixDiscoveryBox.DrugTypeVisuals x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewMixDiscoveryBox.__c.NativeMethodInfoPtr__ShowProduct_b__11_4_Internal_Boolean_DrugTypeVisuals_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D425 RID: 54309 RVA: 0x0032A4F0 File Offset: 0x003286F0
			[CallerCount(0)]
			public unsafe bool _ShowProduct_b__11_5(NewMixDiscoveryBox.DrugTypeVisuals x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewMixDiscoveryBox.__c.NativeMethodInfoPtr__ShowProduct_b__11_5_Internal_Boolean_DrugTypeVisuals_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D426 RID: 54310 RVA: 0x000673DE File Offset: 0x000655DE
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170041C2 RID: 16834
			// (get) Token: 0x0600D427 RID: 54311 RVA: 0x0032A540 File Offset: 0x00328740
			// (set) Token: 0x0600D428 RID: 54312 RVA: 0x000673E7 File Offset: 0x000655E7
			public unsafe static NewMixDiscoveryBox.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NewMixDiscoveryBox.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NewMixDiscoveryBox.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NewMixDiscoveryBox.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041C3 RID: 16835
			// (get) Token: 0x0600D429 RID: 54313 RVA: 0x0032A568 File Offset: 0x00328768
			// (set) Token: 0x0600D42A RID: 54314 RVA: 0x000673F9 File Offset: 0x000655F9
			public unsafe static Func<NewMixDiscoveryBox.DrugTypeVisuals, bool> __9__11_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NewMixDiscoveryBox.__c.NativeFieldInfoPtr___9__11_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<NewMixDiscoveryBox.DrugTypeVisuals, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NewMixDiscoveryBox.__c.NativeFieldInfoPtr___9__11_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041C4 RID: 16836
			// (get) Token: 0x0600D42B RID: 54315 RVA: 0x0032A590 File Offset: 0x00328790
			// (set) Token: 0x0600D42C RID: 54316 RVA: 0x0006740B File Offset: 0x0006560B
			public unsafe static Func<NewMixDiscoveryBox.DrugTypeVisuals, bool> __9__11_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NewMixDiscoveryBox.__c.NativeFieldInfoPtr___9__11_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<NewMixDiscoveryBox.DrugTypeVisuals, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NewMixDiscoveryBox.__c.NativeFieldInfoPtr___9__11_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041C5 RID: 16837
			// (get) Token: 0x0600D42D RID: 54317 RVA: 0x0032A5B8 File Offset: 0x003287B8
			// (set) Token: 0x0600D42E RID: 54318 RVA: 0x0006741D File Offset: 0x0006561D
			public unsafe static Func<NewMixDiscoveryBox.DrugTypeVisuals, bool> __9__11_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NewMixDiscoveryBox.__c.NativeFieldInfoPtr___9__11_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<NewMixDiscoveryBox.DrugTypeVisuals, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NewMixDiscoveryBox.__c.NativeFieldInfoPtr___9__11_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041C6 RID: 16838
			// (get) Token: 0x0600D42F RID: 54319 RVA: 0x0032A5E0 File Offset: 0x003287E0
			// (set) Token: 0x0600D430 RID: 54320 RVA: 0x0006742F File Offset: 0x0006562F
			public unsafe static Func<NewMixDiscoveryBox.DrugTypeVisuals, bool> __9__11_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NewMixDiscoveryBox.__c.NativeFieldInfoPtr___9__11_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<NewMixDiscoveryBox.DrugTypeVisuals, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NewMixDiscoveryBox.__c.NativeFieldInfoPtr___9__11_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041C7 RID: 16839
			// (get) Token: 0x0600D431 RID: 54321 RVA: 0x0032A608 File Offset: 0x00328808
			// (set) Token: 0x0600D432 RID: 54322 RVA: 0x00067441 File Offset: 0x00065641
			public unsafe static Func<NewMixDiscoveryBox.DrugTypeVisuals, bool> __9__11_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NewMixDiscoveryBox.__c.NativeFieldInfoPtr___9__11_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<NewMixDiscoveryBox.DrugTypeVisuals, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NewMixDiscoveryBox.__c.NativeFieldInfoPtr___9__11_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041C8 RID: 16840
			// (get) Token: 0x0600D433 RID: 54323 RVA: 0x0032A630 File Offset: 0x00328830
			// (set) Token: 0x0600D434 RID: 54324 RVA: 0x00067453 File Offset: 0x00065653
			public unsafe static Func<NewMixDiscoveryBox.DrugTypeVisuals, bool> __9__11_5
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NewMixDiscoveryBox.__c.NativeFieldInfoPtr___9__11_5, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<NewMixDiscoveryBox.DrugTypeVisuals, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NewMixDiscoveryBox.__c.NativeFieldInfoPtr___9__11_5, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008ED3 RID: 36563
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008ED4 RID: 36564
			private static readonly IntPtr NativeFieldInfoPtr___9__11_0;

			// Token: 0x04008ED5 RID: 36565
			private static readonly IntPtr NativeFieldInfoPtr___9__11_1;

			// Token: 0x04008ED6 RID: 36566
			private static readonly IntPtr NativeFieldInfoPtr___9__11_2;

			// Token: 0x04008ED7 RID: 36567
			private static readonly IntPtr NativeFieldInfoPtr___9__11_3;

			// Token: 0x04008ED8 RID: 36568
			private static readonly IntPtr NativeFieldInfoPtr___9__11_4;

			// Token: 0x04008ED9 RID: 36569
			private static readonly IntPtr NativeFieldInfoPtr___9__11_5;

			// Token: 0x04008EDA RID: 36570
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008EDB RID: 36571
			private static readonly IntPtr NativeMethodInfoPtr__ShowProduct_b__11_0_Internal_Boolean_DrugTypeVisuals_0;

			// Token: 0x04008EDC RID: 36572
			private static readonly IntPtr NativeMethodInfoPtr__ShowProduct_b__11_1_Internal_Boolean_DrugTypeVisuals_0;

			// Token: 0x04008EDD RID: 36573
			private static readonly IntPtr NativeMethodInfoPtr__ShowProduct_b__11_2_Internal_Boolean_DrugTypeVisuals_0;

			// Token: 0x04008EDE RID: 36574
			private static readonly IntPtr NativeMethodInfoPtr__ShowProduct_b__11_3_Internal_Boolean_DrugTypeVisuals_0;

			// Token: 0x04008EDF RID: 36575
			private static readonly IntPtr NativeMethodInfoPtr__ShowProduct_b__11_4_Internal_Boolean_DrugTypeVisuals_0;

			// Token: 0x04008EE0 RID: 36576
			private static readonly IntPtr NativeMethodInfoPtr__ShowProduct_b__11_5_Internal_Boolean_DrugTypeVisuals_0;
		}
	}
}
