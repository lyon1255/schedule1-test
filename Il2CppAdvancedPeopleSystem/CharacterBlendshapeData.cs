using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppAdvancedPeopleSystem
{
	// Token: 0x0200015A RID: 346
	[Serializable]
	public class CharacterBlendshapeData : Object
	{
		// Token: 0x06001C22 RID: 7202 RVA: 0x000C7DE8 File Offset: 0x000C5FE8
		// Note: this type is marked as 'beforefieldinit'.
		static CharacterBlendshapeData()
		{
			Il2CppClassPointerStore<CharacterBlendshapeData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "AdvancedPeopleSystem", "CharacterBlendshapeData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterBlendshapeData>.NativeClassPtr);
			CharacterBlendshapeData.NativeFieldInfoPtr_blendshapeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterBlendshapeData>.NativeClassPtr, "blendshapeName");
			CharacterBlendshapeData.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterBlendshapeData>.NativeClassPtr, "type");
			CharacterBlendshapeData.NativeFieldInfoPtr_group = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterBlendshapeData>.NativeClassPtr, "group");
			CharacterBlendshapeData.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterBlendshapeData>.NativeClassPtr, "value");
			CharacterBlendshapeData.NativeMethodInfoPtr__ctor_Public_Void_String_CharacterBlendShapeType_CharacterBlendShapeGroup_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterBlendshapeData>.NativeClassPtr, 100666241);
			CharacterBlendshapeData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterBlendshapeData>.NativeClassPtr, 100666242);
		}

		// Token: 0x06001C23 RID: 7203 RVA: 0x000C7E90 File Offset: 0x000C6090
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 100605, RefRangeEnd = 100607, XrefRangeStart = 100603, XrefRangeEnd = 100605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CharacterBlendshapeData(string name, CharacterBlendShapeType t, CharacterBlendShapeGroup g, float value = 0f) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterBlendshapeData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref t;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref g;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterBlendshapeData.NativeMethodInfoPtr__ctor_Public_Void_String_CharacterBlendShapeType_CharacterBlendShapeGroup_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C24 RID: 7204 RVA: 0x000C7F08 File Offset: 0x000C6108
		[CallerCount(2259)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CharacterBlendshapeData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterBlendshapeData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterBlendshapeData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C25 RID: 7205 RVA: 0x00010059 File Offset: 0x0000E259
		public CharacterBlendshapeData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170009D4 RID: 2516
		// (get) Token: 0x06001C26 RID: 7206 RVA: 0x000C7F44 File Offset: 0x000C6144
		// (set) Token: 0x06001C27 RID: 7207 RVA: 0x00010062 File Offset: 0x0000E262
		public unsafe string blendshapeName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterBlendshapeData.NativeFieldInfoPtr_blendshapeName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterBlendshapeData.NativeFieldInfoPtr_blendshapeName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170009D5 RID: 2517
		// (get) Token: 0x06001C28 RID: 7208 RVA: 0x000C7F6C File Offset: 0x000C616C
		// (set) Token: 0x06001C29 RID: 7209 RVA: 0x00010081 File Offset: 0x0000E281
		public unsafe CharacterBlendShapeType type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterBlendshapeData.NativeFieldInfoPtr_type);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterBlendshapeData.NativeFieldInfoPtr_type)) = value;
			}
		}

		// Token: 0x170009D6 RID: 2518
		// (get) Token: 0x06001C2A RID: 7210 RVA: 0x000C7F94 File Offset: 0x000C6194
		// (set) Token: 0x06001C2B RID: 7211 RVA: 0x0001009C File Offset: 0x0000E29C
		public unsafe CharacterBlendShapeGroup group
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterBlendshapeData.NativeFieldInfoPtr_group);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterBlendshapeData.NativeFieldInfoPtr_group)) = value;
			}
		}

		// Token: 0x170009D7 RID: 2519
		// (get) Token: 0x06001C2C RID: 7212 RVA: 0x000C7FBC File Offset: 0x000C61BC
		// (set) Token: 0x06001C2D RID: 7213 RVA: 0x000100B7 File Offset: 0x0000E2B7
		public unsafe float value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterBlendshapeData.NativeFieldInfoPtr_value);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterBlendshapeData.NativeFieldInfoPtr_value)) = value;
			}
		}

		// Token: 0x0400126E RID: 4718
		private static readonly IntPtr NativeFieldInfoPtr_blendshapeName;

		// Token: 0x0400126F RID: 4719
		private static readonly IntPtr NativeFieldInfoPtr_type;

		// Token: 0x04001270 RID: 4720
		private static readonly IntPtr NativeFieldInfoPtr_group;

		// Token: 0x04001271 RID: 4721
		private static readonly IntPtr NativeFieldInfoPtr_value;

		// Token: 0x04001272 RID: 4722
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_CharacterBlendShapeType_CharacterBlendShapeGroup_Single_0;

		// Token: 0x04001273 RID: 4723
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
