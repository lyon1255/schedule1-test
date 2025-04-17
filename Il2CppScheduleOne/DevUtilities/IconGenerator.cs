using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Packaging;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x02000455 RID: 1109
	public class IconGenerator : Singleton<IconGenerator>
	{
		// Token: 0x0600607A RID: 24698 RVA: 0x001B9464 File Offset: 0x001B7664
		// Note: this type is marked as 'beforefieldinit'.
		static IconGenerator()
		{
			Il2CppClassPointerStore<IconGenerator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "IconGenerator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IconGenerator>.NativeClassPtr);
			IconGenerator.NativeFieldInfoPtr_IconSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconGenerator>.NativeClassPtr, "IconSize");
			IconGenerator.NativeFieldInfoPtr_OutputPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconGenerator>.NativeClassPtr, "OutputPath");
			IconGenerator.NativeFieldInfoPtr_ModifyLighting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconGenerator>.NativeClassPtr, "ModifyLighting");
			IconGenerator.NativeFieldInfoPtr_Registry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconGenerator>.NativeClassPtr, "Registry");
			IconGenerator.NativeFieldInfoPtr_CameraPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconGenerator>.NativeClassPtr, "CameraPosition");
			IconGenerator.NativeFieldInfoPtr_MainContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconGenerator>.NativeClassPtr, "MainContainer");
			IconGenerator.NativeFieldInfoPtr_ItemContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconGenerator>.NativeClassPtr, "ItemContainer");
			IconGenerator.NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconGenerator>.NativeClassPtr, "Canvas");
			IconGenerator.NativeFieldInfoPtr_Visuals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconGenerator>.NativeClassPtr, "Visuals");
			IconGenerator.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconGenerator>.NativeClassPtr, 100675576);
			IconGenerator.NativeMethodInfoPtr_GenerateIcon_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconGenerator>.NativeClassPtr, 100675577);
			IconGenerator.NativeMethodInfoPtr_GeneratePackagingIcon_Public_Texture2D_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconGenerator>.NativeClassPtr, 100675578);
			IconGenerator.NativeMethodInfoPtr_GetTexture_Public_Texture2D_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconGenerator>.NativeClassPtr, 100675579);
			IconGenerator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconGenerator>.NativeClassPtr, 100675580);
		}

		// Token: 0x0600607B RID: 24699 RVA: 0x001B95AC File Offset: 0x001B77AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199136, XrefRangeEnd = 199153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IconGenerator.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600607C RID: 24700 RVA: 0x001B95E8 File Offset: 0x001B77E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199153, XrefRangeEnd = 199191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GenerateIcon()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IconGenerator.NativeMethodInfoPtr_GenerateIcon_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600607D RID: 24701 RVA: 0x001B961C File Offset: 0x001B781C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 199237, RefRangeEnd = 199238, XrefRangeStart = 199191, XrefRangeEnd = 199237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Texture2D GeneratePackagingIcon(string packagingID, string productID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(packagingID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(productID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IconGenerator.NativeMethodInfoPtr_GeneratePackagingIcon_Public_Texture2D_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr3) : null;
		}

		// Token: 0x0600607E RID: 24702 RVA: 0x001B9680 File Offset: 0x001B7880
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 199270, RefRangeEnd = 199274, XrefRangeStart = 199238, XrefRangeEnd = 199270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Texture2D GetTexture(Transform model)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(model);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IconGenerator.NativeMethodInfoPtr_GetTexture_Public_Texture2D_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr3) : null;
		}

		// Token: 0x0600607F RID: 24703 RVA: 0x001B96D0 File Offset: 0x001B78D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199274, XrefRangeEnd = 199277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IconGenerator() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IconGenerator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IconGenerator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006080 RID: 24704 RVA: 0x0002D994 File Offset: 0x0002BB94
		public IconGenerator(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001D02 RID: 7426
		// (get) Token: 0x06006081 RID: 24705 RVA: 0x001B970C File Offset: 0x001B790C
		// (set) Token: 0x06006082 RID: 24706 RVA: 0x0002D99D File Offset: 0x0002BB9D
		public unsafe int IconSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconGenerator.NativeFieldInfoPtr_IconSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconGenerator.NativeFieldInfoPtr_IconSize)) = value;
			}
		}

		// Token: 0x17001D03 RID: 7427
		// (get) Token: 0x06006083 RID: 24707 RVA: 0x001B9734 File Offset: 0x001B7934
		// (set) Token: 0x06006084 RID: 24708 RVA: 0x0002D9B8 File Offset: 0x0002BBB8
		public unsafe string OutputPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconGenerator.NativeFieldInfoPtr_OutputPath);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconGenerator.NativeFieldInfoPtr_OutputPath), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001D04 RID: 7428
		// (get) Token: 0x06006085 RID: 24709 RVA: 0x001B975C File Offset: 0x001B795C
		// (set) Token: 0x06006086 RID: 24710 RVA: 0x0002D9D7 File Offset: 0x0002BBD7
		public unsafe bool ModifyLighting
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconGenerator.NativeFieldInfoPtr_ModifyLighting);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconGenerator.NativeFieldInfoPtr_ModifyLighting)) = value;
			}
		}

		// Token: 0x17001D05 RID: 7429
		// (get) Token: 0x06006087 RID: 24711 RVA: 0x001B9784 File Offset: 0x001B7984
		// (set) Token: 0x06006088 RID: 24712 RVA: 0x0002D9F2 File Offset: 0x0002BBF2
		public unsafe Registry Registry
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconGenerator.NativeFieldInfoPtr_Registry);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Registry>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconGenerator.NativeFieldInfoPtr_Registry), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D06 RID: 7430
		// (get) Token: 0x06006089 RID: 24713 RVA: 0x001B97B4 File Offset: 0x001B79B4
		// (set) Token: 0x0600608A RID: 24714 RVA: 0x0002DA11 File Offset: 0x0002BC11
		public unsafe Camera CameraPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconGenerator.NativeFieldInfoPtr_CameraPosition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconGenerator.NativeFieldInfoPtr_CameraPosition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D07 RID: 7431
		// (get) Token: 0x0600608B RID: 24715 RVA: 0x001B97E4 File Offset: 0x001B79E4
		// (set) Token: 0x0600608C RID: 24716 RVA: 0x0002DA30 File Offset: 0x0002BC30
		public unsafe Transform MainContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconGenerator.NativeFieldInfoPtr_MainContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconGenerator.NativeFieldInfoPtr_MainContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D08 RID: 7432
		// (get) Token: 0x0600608D RID: 24717 RVA: 0x001B9814 File Offset: 0x001B7A14
		// (set) Token: 0x0600608E RID: 24718 RVA: 0x0002DA4F File Offset: 0x0002BC4F
		public unsafe Transform ItemContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconGenerator.NativeFieldInfoPtr_ItemContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconGenerator.NativeFieldInfoPtr_ItemContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D09 RID: 7433
		// (get) Token: 0x0600608F RID: 24719 RVA: 0x001B9844 File Offset: 0x001B7A44
		// (set) Token: 0x06006090 RID: 24720 RVA: 0x0002DA6E File Offset: 0x0002BC6E
		public unsafe GameObject Canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconGenerator.NativeFieldInfoPtr_Canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconGenerator.NativeFieldInfoPtr_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D0A RID: 7434
		// (get) Token: 0x06006091 RID: 24721 RVA: 0x001B9874 File Offset: 0x001B7A74
		// (set) Token: 0x06006092 RID: 24722 RVA: 0x0002DA8D File Offset: 0x0002BC8D
		public unsafe List<IconGenerator.PackagingVisuals> Visuals
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconGenerator.NativeFieldInfoPtr_Visuals);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<IconGenerator.PackagingVisuals>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconGenerator.NativeFieldInfoPtr_Visuals), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040041DF RID: 16863
		private static readonly IntPtr NativeFieldInfoPtr_IconSize;

		// Token: 0x040041E0 RID: 16864
		private static readonly IntPtr NativeFieldInfoPtr_OutputPath;

		// Token: 0x040041E1 RID: 16865
		private static readonly IntPtr NativeFieldInfoPtr_ModifyLighting;

		// Token: 0x040041E2 RID: 16866
		private static readonly IntPtr NativeFieldInfoPtr_Registry;

		// Token: 0x040041E3 RID: 16867
		private static readonly IntPtr NativeFieldInfoPtr_CameraPosition;

		// Token: 0x040041E4 RID: 16868
		private static readonly IntPtr NativeFieldInfoPtr_MainContainer;

		// Token: 0x040041E5 RID: 16869
		private static readonly IntPtr NativeFieldInfoPtr_ItemContainer;

		// Token: 0x040041E6 RID: 16870
		private static readonly IntPtr NativeFieldInfoPtr_Canvas;

		// Token: 0x040041E7 RID: 16871
		private static readonly IntPtr NativeFieldInfoPtr_Visuals;

		// Token: 0x040041E8 RID: 16872
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x040041E9 RID: 16873
		private static readonly IntPtr NativeMethodInfoPtr_GenerateIcon_Public_Void_0;

		// Token: 0x040041EA RID: 16874
		private static readonly IntPtr NativeMethodInfoPtr_GeneratePackagingIcon_Public_Texture2D_String_String_0;

		// Token: 0x040041EB RID: 16875
		private static readonly IntPtr NativeMethodInfoPtr_GetTexture_Public_Texture2D_Transform_0;

		// Token: 0x040041EC RID: 16876
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000A0F RID: 2575
		[Serializable]
		public class PackagingVisuals : Il2CppSystem.Object
		{
			// Token: 0x0600CEAD RID: 52909 RVA: 0x0031B210 File Offset: 0x00319410
			// Note: this type is marked as 'beforefieldinit'.
			static PackagingVisuals()
			{
				Il2CppClassPointerStore<IconGenerator.PackagingVisuals>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IconGenerator>.NativeClassPtr, "PackagingVisuals");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IconGenerator.PackagingVisuals>.NativeClassPtr);
				IconGenerator.PackagingVisuals.NativeFieldInfoPtr_PackagingID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconGenerator.PackagingVisuals>.NativeClassPtr, "PackagingID");
				IconGenerator.PackagingVisuals.NativeFieldInfoPtr_Visuals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconGenerator.PackagingVisuals>.NativeClassPtr, "Visuals");
				IconGenerator.PackagingVisuals.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconGenerator.PackagingVisuals>.NativeClassPtr, 100675581);
			}

			// Token: 0x0600CEAE RID: 52910 RVA: 0x0031B278 File Offset: 0x00319478
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PackagingVisuals() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IconGenerator.PackagingVisuals>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IconGenerator.PackagingVisuals.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CEAF RID: 52911 RVA: 0x00064848 File Offset: 0x00062A48
			public PackagingVisuals(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004045 RID: 16453
			// (get) Token: 0x0600CEB0 RID: 52912 RVA: 0x0031B2B4 File Offset: 0x003194B4
			// (set) Token: 0x0600CEB1 RID: 52913 RVA: 0x00064851 File Offset: 0x00062A51
			public unsafe string PackagingID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconGenerator.PackagingVisuals.NativeFieldInfoPtr_PackagingID);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconGenerator.PackagingVisuals.NativeFieldInfoPtr_PackagingID), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17004046 RID: 16454
			// (get) Token: 0x0600CEB2 RID: 52914 RVA: 0x0031B2DC File Offset: 0x003194DC
			// (set) Token: 0x0600CEB3 RID: 52915 RVA: 0x00064870 File Offset: 0x00062A70
			public unsafe FilledPackagingVisuals Visuals
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconGenerator.PackagingVisuals.NativeFieldInfoPtr_Visuals);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FilledPackagingVisuals>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconGenerator.PackagingVisuals.NativeFieldInfoPtr_Visuals), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008B77 RID: 35703
			private static readonly IntPtr NativeFieldInfoPtr_PackagingID;

			// Token: 0x04008B78 RID: 35704
			private static readonly IntPtr NativeFieldInfoPtr_Visuals;

			// Token: 0x04008B79 RID: 35705
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000A10 RID: 2576
		[ObfuscatedName("ScheduleOne.DevUtilities.IconGenerator+<>c__DisplayClass12_0")]
		public sealed class __c__DisplayClass12_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CEB4 RID: 52916 RVA: 0x0031B30C File Offset: 0x0031950C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass12_0()
			{
				Il2CppClassPointerStore<IconGenerator.__c__DisplayClass12_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IconGenerator>.NativeClassPtr, "<>c__DisplayClass12_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IconGenerator.__c__DisplayClass12_0>.NativeClassPtr);
				IconGenerator.__c__DisplayClass12_0.NativeFieldInfoPtr_packagingID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconGenerator.__c__DisplayClass12_0>.NativeClassPtr, "packagingID");
				IconGenerator.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconGenerator.__c__DisplayClass12_0>.NativeClassPtr, 100675582);
				IconGenerator.__c__DisplayClass12_0.NativeMethodInfoPtr__GeneratePackagingIcon_b__0_Internal_Boolean_PackagingVisuals_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconGenerator.__c__DisplayClass12_0>.NativeClassPtr, 100675583);
			}

			// Token: 0x0600CEB5 RID: 52917 RVA: 0x0031B374 File Offset: 0x00319574
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass12_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IconGenerator.__c__DisplayClass12_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IconGenerator.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CEB6 RID: 52918 RVA: 0x0031B3B0 File Offset: 0x003195B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199134, XrefRangeEnd = 199136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GeneratePackagingIcon_b__0(IconGenerator.PackagingVisuals x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IconGenerator.__c__DisplayClass12_0.NativeMethodInfoPtr__GeneratePackagingIcon_b__0_Internal_Boolean_PackagingVisuals_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CEB7 RID: 52919 RVA: 0x0006488F File Offset: 0x00062A8F
			public __c__DisplayClass12_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004047 RID: 16455
			// (get) Token: 0x0600CEB8 RID: 52920 RVA: 0x0031B400 File Offset: 0x00319600
			// (set) Token: 0x0600CEB9 RID: 52921 RVA: 0x00064898 File Offset: 0x00062A98
			public unsafe string packagingID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconGenerator.__c__DisplayClass12_0.NativeFieldInfoPtr_packagingID);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IconGenerator.__c__DisplayClass12_0.NativeFieldInfoPtr_packagingID), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04008B7A RID: 35706
			private static readonly IntPtr NativeFieldInfoPtr_packagingID;

			// Token: 0x04008B7B RID: 35707
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008B7C RID: 35708
			private static readonly IntPtr NativeMethodInfoPtr__GeneratePackagingIcon_b__0_Internal_Boolean_PackagingVisuals_0;
		}
	}
}
