using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppArdenfall.Utilities
{
	// Token: 0x02000166 RID: 358
	[Serializable]
	public class MaterialOverrides : Il2CppSystem.Object
	{
		// Token: 0x06001CDD RID: 7389 RVA: 0x000C9F90 File Offset: 0x000C8190
		// Note: this type is marked as 'beforefieldinit'.
		static MaterialOverrides()
		{
			Il2CppClassPointerStore<MaterialOverrides>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Ardenfall.Utilities", "MaterialOverrides");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaterialOverrides>.NativeClassPtr);
			MaterialOverrides.NativeFieldInfoPtr_textureOverrides = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialOverrides>.NativeClassPtr, "textureOverrides");
			MaterialOverrides.NativeFieldInfoPtr_floatOverrides = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialOverrides>.NativeClassPtr, "floatOverrides");
			MaterialOverrides.NativeFieldInfoPtr_intOverrides = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialOverrides>.NativeClassPtr, "intOverrides");
			MaterialOverrides.NativeFieldInfoPtr_vectorOverrides = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialOverrides>.NativeClassPtr, "vectorOverrides");
			MaterialOverrides.NativeFieldInfoPtr_colorOverrides = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialOverrides>.NativeClassPtr, "colorOverrides");
			MaterialOverrides.NativeMethodInfoPtr_OverrideMaterial_Public_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialOverrides>.NativeClassPtr, 100666315);
			MaterialOverrides.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialOverrides>.NativeClassPtr, 100666316);
		}

		// Token: 0x06001CDE RID: 7390 RVA: 0x000CA04C File Offset: 0x000C824C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 101336, XrefRangeEnd = 101411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OverrideMaterial(Material material)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(material);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialOverrides.NativeMethodInfoPtr_OverrideMaterial_Public_Void_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CDF RID: 7391 RVA: 0x000CA090 File Offset: 0x000C8290
		[CallerCount(2259)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MaterialOverrides() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MaterialOverrides>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialOverrides.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CE0 RID: 7392 RVA: 0x0001072F File Offset: 0x0000E92F
		public MaterialOverrides(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000A0E RID: 2574
		// (get) Token: 0x06001CE1 RID: 7393 RVA: 0x000CA0CC File Offset: 0x000C82CC
		// (set) Token: 0x06001CE2 RID: 7394 RVA: 0x00010738 File Offset: 0x0000E938
		public unsafe List<MaterialOverrides.TextureProperty> textureOverrides
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialOverrides.NativeFieldInfoPtr_textureOverrides);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<MaterialOverrides.TextureProperty>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialOverrides.NativeFieldInfoPtr_textureOverrides), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A0F RID: 2575
		// (get) Token: 0x06001CE3 RID: 7395 RVA: 0x000CA0FC File Offset: 0x000C82FC
		// (set) Token: 0x06001CE4 RID: 7396 RVA: 0x00010757 File Offset: 0x0000E957
		public unsafe List<MaterialOverrides.FloatProperty> floatOverrides
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialOverrides.NativeFieldInfoPtr_floatOverrides);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<MaterialOverrides.FloatProperty>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialOverrides.NativeFieldInfoPtr_floatOverrides), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A10 RID: 2576
		// (get) Token: 0x06001CE5 RID: 7397 RVA: 0x000CA12C File Offset: 0x000C832C
		// (set) Token: 0x06001CE6 RID: 7398 RVA: 0x00010776 File Offset: 0x0000E976
		public unsafe List<MaterialOverrides.IntProperty> intOverrides
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialOverrides.NativeFieldInfoPtr_intOverrides);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<MaterialOverrides.IntProperty>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialOverrides.NativeFieldInfoPtr_intOverrides), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A11 RID: 2577
		// (get) Token: 0x06001CE7 RID: 7399 RVA: 0x000CA15C File Offset: 0x000C835C
		// (set) Token: 0x06001CE8 RID: 7400 RVA: 0x00010795 File Offset: 0x0000E995
		public unsafe List<MaterialOverrides.VectorProperty> vectorOverrides
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialOverrides.NativeFieldInfoPtr_vectorOverrides);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<MaterialOverrides.VectorProperty>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialOverrides.NativeFieldInfoPtr_vectorOverrides), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A12 RID: 2578
		// (get) Token: 0x06001CE9 RID: 7401 RVA: 0x000CA18C File Offset: 0x000C838C
		// (set) Token: 0x06001CEA RID: 7402 RVA: 0x000107B4 File Offset: 0x0000E9B4
		public unsafe List<MaterialOverrides.ColorProperty> colorOverrides
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialOverrides.NativeFieldInfoPtr_colorOverrides);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<MaterialOverrides.ColorProperty>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialOverrides.NativeFieldInfoPtr_colorOverrides), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400131D RID: 4893
		private static readonly IntPtr NativeFieldInfoPtr_textureOverrides;

		// Token: 0x0400131E RID: 4894
		private static readonly IntPtr NativeFieldInfoPtr_floatOverrides;

		// Token: 0x0400131F RID: 4895
		private static readonly IntPtr NativeFieldInfoPtr_intOverrides;

		// Token: 0x04001320 RID: 4896
		private static readonly IntPtr NativeFieldInfoPtr_vectorOverrides;

		// Token: 0x04001321 RID: 4897
		private static readonly IntPtr NativeFieldInfoPtr_colorOverrides;

		// Token: 0x04001322 RID: 4898
		private static readonly IntPtr NativeMethodInfoPtr_OverrideMaterial_Public_Void_Material_0;

		// Token: 0x04001323 RID: 4899
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200086A RID: 2154
		[Serializable]
		public class TextureProperty : Il2CppSystem.Object
		{
			// Token: 0x0600C133 RID: 49459 RVA: 0x002F2B2C File Offset: 0x002F0D2C
			// Note: this type is marked as 'beforefieldinit'.
			static TextureProperty()
			{
				Il2CppClassPointerStore<MaterialOverrides.TextureProperty>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MaterialOverrides>.NativeClassPtr, "TextureProperty");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaterialOverrides.TextureProperty>.NativeClassPtr);
				MaterialOverrides.TextureProperty.NativeFieldInfoPtr_propertyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialOverrides.TextureProperty>.NativeClassPtr, "propertyName");
				MaterialOverrides.TextureProperty.NativeFieldInfoPtr_propertyValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialOverrides.TextureProperty>.NativeClassPtr, "propertyValue");
				MaterialOverrides.TextureProperty.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialOverrides.TextureProperty>.NativeClassPtr, 100666317);
			}

			// Token: 0x0600C134 RID: 49460 RVA: 0x002F2B94 File Offset: 0x002F0D94
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TextureProperty() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MaterialOverrides.TextureProperty>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialOverrides.TextureProperty.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C135 RID: 49461 RVA: 0x0005E7A6 File Offset: 0x0005C9A6
			public TextureProperty(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003C35 RID: 15413
			// (get) Token: 0x0600C136 RID: 49462 RVA: 0x002F2BD0 File Offset: 0x002F0DD0
			// (set) Token: 0x0600C137 RID: 49463 RVA: 0x0005E7AF File Offset: 0x0005C9AF
			public unsafe string propertyName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialOverrides.TextureProperty.NativeFieldInfoPtr_propertyName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialOverrides.TextureProperty.NativeFieldInfoPtr_propertyName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003C36 RID: 15414
			// (get) Token: 0x0600C138 RID: 49464 RVA: 0x002F2BF8 File Offset: 0x002F0DF8
			// (set) Token: 0x0600C139 RID: 49465 RVA: 0x0005E7CE File Offset: 0x0005C9CE
			public unsafe Texture2D propertyValue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialOverrides.TextureProperty.NativeFieldInfoPtr_propertyValue);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialOverrides.TextureProperty.NativeFieldInfoPtr_propertyValue), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040082D7 RID: 33495
			private static readonly IntPtr NativeFieldInfoPtr_propertyName;

			// Token: 0x040082D8 RID: 33496
			private static readonly IntPtr NativeFieldInfoPtr_propertyValue;

			// Token: 0x040082D9 RID: 33497
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200086B RID: 2155
		[Serializable]
		public class FloatProperty : Il2CppSystem.Object
		{
			// Token: 0x0600C13A RID: 49466 RVA: 0x002F2C28 File Offset: 0x002F0E28
			// Note: this type is marked as 'beforefieldinit'.
			static FloatProperty()
			{
				Il2CppClassPointerStore<MaterialOverrides.FloatProperty>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MaterialOverrides>.NativeClassPtr, "FloatProperty");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaterialOverrides.FloatProperty>.NativeClassPtr);
				MaterialOverrides.FloatProperty.NativeFieldInfoPtr_propertyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialOverrides.FloatProperty>.NativeClassPtr, "propertyName");
				MaterialOverrides.FloatProperty.NativeFieldInfoPtr_propertyValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialOverrides.FloatProperty>.NativeClassPtr, "propertyValue");
				MaterialOverrides.FloatProperty.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialOverrides.FloatProperty>.NativeClassPtr, 100666318);
			}

			// Token: 0x0600C13B RID: 49467 RVA: 0x002F2C90 File Offset: 0x002F0E90
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe FloatProperty() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MaterialOverrides.FloatProperty>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialOverrides.FloatProperty.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C13C RID: 49468 RVA: 0x0005E7ED File Offset: 0x0005C9ED
			public FloatProperty(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003C37 RID: 15415
			// (get) Token: 0x0600C13D RID: 49469 RVA: 0x002F2CCC File Offset: 0x002F0ECC
			// (set) Token: 0x0600C13E RID: 49470 RVA: 0x0005E7F6 File Offset: 0x0005C9F6
			public unsafe string propertyName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialOverrides.FloatProperty.NativeFieldInfoPtr_propertyName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialOverrides.FloatProperty.NativeFieldInfoPtr_propertyName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003C38 RID: 15416
			// (get) Token: 0x0600C13F RID: 49471 RVA: 0x002F2CF4 File Offset: 0x002F0EF4
			// (set) Token: 0x0600C140 RID: 49472 RVA: 0x0005E815 File Offset: 0x0005CA15
			public unsafe float propertyValue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialOverrides.FloatProperty.NativeFieldInfoPtr_propertyValue);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialOverrides.FloatProperty.NativeFieldInfoPtr_propertyValue)) = value;
				}
			}

			// Token: 0x040082DA RID: 33498
			private static readonly IntPtr NativeFieldInfoPtr_propertyName;

			// Token: 0x040082DB RID: 33499
			private static readonly IntPtr NativeFieldInfoPtr_propertyValue;

			// Token: 0x040082DC RID: 33500
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200086C RID: 2156
		[Serializable]
		public class IntProperty : Il2CppSystem.Object
		{
			// Token: 0x0600C141 RID: 49473 RVA: 0x002F2D1C File Offset: 0x002F0F1C
			// Note: this type is marked as 'beforefieldinit'.
			static IntProperty()
			{
				Il2CppClassPointerStore<MaterialOverrides.IntProperty>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MaterialOverrides>.NativeClassPtr, "IntProperty");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaterialOverrides.IntProperty>.NativeClassPtr);
				MaterialOverrides.IntProperty.NativeFieldInfoPtr_propertyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialOverrides.IntProperty>.NativeClassPtr, "propertyName");
				MaterialOverrides.IntProperty.NativeFieldInfoPtr_propertyValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialOverrides.IntProperty>.NativeClassPtr, "propertyValue");
				MaterialOverrides.IntProperty.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialOverrides.IntProperty>.NativeClassPtr, 100666319);
			}

			// Token: 0x0600C142 RID: 49474 RVA: 0x002F2D84 File Offset: 0x002F0F84
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IntProperty() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MaterialOverrides.IntProperty>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialOverrides.IntProperty.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C143 RID: 49475 RVA: 0x0005E830 File Offset: 0x0005CA30
			public IntProperty(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003C39 RID: 15417
			// (get) Token: 0x0600C144 RID: 49476 RVA: 0x002F2DC0 File Offset: 0x002F0FC0
			// (set) Token: 0x0600C145 RID: 49477 RVA: 0x0005E839 File Offset: 0x0005CA39
			public unsafe string propertyName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialOverrides.IntProperty.NativeFieldInfoPtr_propertyName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialOverrides.IntProperty.NativeFieldInfoPtr_propertyName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003C3A RID: 15418
			// (get) Token: 0x0600C146 RID: 49478 RVA: 0x002F2DE8 File Offset: 0x002F0FE8
			// (set) Token: 0x0600C147 RID: 49479 RVA: 0x0005E858 File Offset: 0x0005CA58
			public unsafe int propertyValue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialOverrides.IntProperty.NativeFieldInfoPtr_propertyValue);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialOverrides.IntProperty.NativeFieldInfoPtr_propertyValue)) = value;
				}
			}

			// Token: 0x040082DD RID: 33501
			private static readonly IntPtr NativeFieldInfoPtr_propertyName;

			// Token: 0x040082DE RID: 33502
			private static readonly IntPtr NativeFieldInfoPtr_propertyValue;

			// Token: 0x040082DF RID: 33503
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200086D RID: 2157
		[Serializable]
		public class VectorProperty : Il2CppSystem.Object
		{
			// Token: 0x0600C148 RID: 49480 RVA: 0x002F2E10 File Offset: 0x002F1010
			// Note: this type is marked as 'beforefieldinit'.
			static VectorProperty()
			{
				Il2CppClassPointerStore<MaterialOverrides.VectorProperty>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MaterialOverrides>.NativeClassPtr, "VectorProperty");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaterialOverrides.VectorProperty>.NativeClassPtr);
				MaterialOverrides.VectorProperty.NativeFieldInfoPtr_propertyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialOverrides.VectorProperty>.NativeClassPtr, "propertyName");
				MaterialOverrides.VectorProperty.NativeFieldInfoPtr_propertyValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialOverrides.VectorProperty>.NativeClassPtr, "propertyValue");
				MaterialOverrides.VectorProperty.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialOverrides.VectorProperty>.NativeClassPtr, 100666320);
			}

			// Token: 0x0600C149 RID: 49481 RVA: 0x002F2E78 File Offset: 0x002F1078
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe VectorProperty() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MaterialOverrides.VectorProperty>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialOverrides.VectorProperty.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C14A RID: 49482 RVA: 0x0005E873 File Offset: 0x0005CA73
			public VectorProperty(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003C3B RID: 15419
			// (get) Token: 0x0600C14B RID: 49483 RVA: 0x002F2EB4 File Offset: 0x002F10B4
			// (set) Token: 0x0600C14C RID: 49484 RVA: 0x0005E87C File Offset: 0x0005CA7C
			public unsafe string propertyName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialOverrides.VectorProperty.NativeFieldInfoPtr_propertyName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialOverrides.VectorProperty.NativeFieldInfoPtr_propertyName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003C3C RID: 15420
			// (get) Token: 0x0600C14D RID: 49485 RVA: 0x002F2EDC File Offset: 0x002F10DC
			// (set) Token: 0x0600C14E RID: 49486 RVA: 0x0005E89B File Offset: 0x0005CA9B
			public unsafe Vector4 propertyValue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialOverrides.VectorProperty.NativeFieldInfoPtr_propertyValue);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialOverrides.VectorProperty.NativeFieldInfoPtr_propertyValue)) = value;
				}
			}

			// Token: 0x040082E0 RID: 33504
			private static readonly IntPtr NativeFieldInfoPtr_propertyName;

			// Token: 0x040082E1 RID: 33505
			private static readonly IntPtr NativeFieldInfoPtr_propertyValue;

			// Token: 0x040082E2 RID: 33506
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200086E RID: 2158
		[Serializable]
		public class ColorProperty : Il2CppSystem.Object
		{
			// Token: 0x0600C14F RID: 49487 RVA: 0x002F2F04 File Offset: 0x002F1104
			// Note: this type is marked as 'beforefieldinit'.
			static ColorProperty()
			{
				Il2CppClassPointerStore<MaterialOverrides.ColorProperty>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MaterialOverrides>.NativeClassPtr, "ColorProperty");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaterialOverrides.ColorProperty>.NativeClassPtr);
				MaterialOverrides.ColorProperty.NativeFieldInfoPtr_propertyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialOverrides.ColorProperty>.NativeClassPtr, "propertyName");
				MaterialOverrides.ColorProperty.NativeFieldInfoPtr_propertyValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialOverrides.ColorProperty>.NativeClassPtr, "propertyValue");
				MaterialOverrides.ColorProperty.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialOverrides.ColorProperty>.NativeClassPtr, 100666321);
			}

			// Token: 0x0600C150 RID: 49488 RVA: 0x002F2F6C File Offset: 0x002F116C
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ColorProperty() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MaterialOverrides.ColorProperty>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialOverrides.ColorProperty.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C151 RID: 49489 RVA: 0x0005E8B6 File Offset: 0x0005CAB6
			public ColorProperty(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003C3D RID: 15421
			// (get) Token: 0x0600C152 RID: 49490 RVA: 0x002F2FA8 File Offset: 0x002F11A8
			// (set) Token: 0x0600C153 RID: 49491 RVA: 0x0005E8BF File Offset: 0x0005CABF
			public unsafe string propertyName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialOverrides.ColorProperty.NativeFieldInfoPtr_propertyName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialOverrides.ColorProperty.NativeFieldInfoPtr_propertyName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003C3E RID: 15422
			// (get) Token: 0x0600C154 RID: 49492 RVA: 0x002F2FD0 File Offset: 0x002F11D0
			// (set) Token: 0x0600C155 RID: 49493 RVA: 0x0005E8DE File Offset: 0x0005CADE
			public unsafe Color propertyValue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialOverrides.ColorProperty.NativeFieldInfoPtr_propertyValue);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MaterialOverrides.ColorProperty.NativeFieldInfoPtr_propertyValue)) = value;
				}
			}

			// Token: 0x040082E3 RID: 33507
			private static readonly IntPtr NativeFieldInfoPtr_propertyName;

			// Token: 0x040082E4 RID: 33508
			private static readonly IntPtr NativeFieldInfoPtr_propertyValue;

			// Token: 0x040082E5 RID: 33509
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
