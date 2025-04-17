using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.AvatarFramework.Customization;
using UnityEngine;

namespace Il2CppScheduleOne.UI.CharacterCreator
{
	// Token: 0x020006FB RID: 1787
	public class BaseCharacterCreatorField : MonoBehaviour
	{
		// Token: 0x0600A068 RID: 41064 RVA: 0x00286428 File Offset: 0x00284628
		// Note: this type is marked as 'beforefieldinit'.
		static BaseCharacterCreatorField()
		{
			Il2CppClassPointerStore<BaseCharacterCreatorField>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.CharacterCreator", "BaseCharacterCreatorField");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BaseCharacterCreatorField>.NativeClassPtr);
			BaseCharacterCreatorField.NativeFieldInfoPtr_PropertyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseCharacterCreatorField>.NativeClassPtr, "PropertyName");
			BaseCharacterCreatorField.NativeFieldInfoPtr_Category = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseCharacterCreatorField>.NativeClassPtr, "Category");
			BaseCharacterCreatorField.NativeFieldInfoPtr_Creator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseCharacterCreatorField>.NativeClassPtr, "Creator");
			BaseCharacterCreatorField.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseCharacterCreatorField>.NativeClassPtr, 100682921);
			BaseCharacterCreatorField.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseCharacterCreatorField>.NativeClassPtr, 100682922);
			BaseCharacterCreatorField.NativeMethodInfoPtr_ApplyValue_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseCharacterCreatorField>.NativeClassPtr, 100682923);
			BaseCharacterCreatorField.NativeMethodInfoPtr_WriteValue_Public_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseCharacterCreatorField>.NativeClassPtr, 100682924);
			BaseCharacterCreatorField.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseCharacterCreatorField>.NativeClassPtr, 100682925);
		}

		// Token: 0x0600A069 RID: 41065 RVA: 0x002864F8 File Offset: 0x002846F8
		[CallerCount(13604)]
		[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseCharacterCreatorField.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A06A RID: 41066 RVA: 0x00286534 File Offset: 0x00284734
		[CallerCount(13604)]
		[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseCharacterCreatorField.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A06B RID: 41067 RVA: 0x00286570 File Offset: 0x00284770
		[CallerCount(13604)]
		[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ApplyValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseCharacterCreatorField.NativeMethodInfoPtr_ApplyValue_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A06C RID: 41068 RVA: 0x002865AC File Offset: 0x002847AC
		[CallerCount(13604)]
		[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void WriteValue(bool applyValue = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref applyValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseCharacterCreatorField.NativeMethodInfoPtr_WriteValue_Public_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A06D RID: 41069 RVA: 0x002865F8 File Offset: 0x002847F8
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BaseCharacterCreatorField() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BaseCharacterCreatorField>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseCharacterCreatorField.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600A06E RID: 41070 RVA: 0x0004EE40 File Offset: 0x0004D040
		public BaseCharacterCreatorField(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003170 RID: 12656
		// (get) Token: 0x0600A06F RID: 41071 RVA: 0x00286634 File Offset: 0x00284834
		// (set) Token: 0x0600A070 RID: 41072 RVA: 0x0004EE49 File Offset: 0x0004D049
		public unsafe string PropertyName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseCharacterCreatorField.NativeFieldInfoPtr_PropertyName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseCharacterCreatorField.NativeFieldInfoPtr_PropertyName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17003171 RID: 12657
		// (get) Token: 0x0600A071 RID: 41073 RVA: 0x0028665C File Offset: 0x0028485C
		// (set) Token: 0x0600A072 RID: 41074 RVA: 0x0004EE68 File Offset: 0x0004D068
		public unsafe CharacterCreator.ECategory Category
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseCharacterCreatorField.NativeFieldInfoPtr_Category);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseCharacterCreatorField.NativeFieldInfoPtr_Category)) = value;
			}
		}

		// Token: 0x17003172 RID: 12658
		// (get) Token: 0x0600A073 RID: 41075 RVA: 0x00286684 File Offset: 0x00284884
		// (set) Token: 0x0600A074 RID: 41076 RVA: 0x0004EE83 File Offset: 0x0004D083
		public unsafe CharacterCreator Creator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseCharacterCreatorField.NativeFieldInfoPtr_Creator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterCreator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseCharacterCreatorField.NativeFieldInfoPtr_Creator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006B8D RID: 27533
		private static readonly IntPtr NativeFieldInfoPtr_PropertyName;

		// Token: 0x04006B8E RID: 27534
		private static readonly IntPtr NativeFieldInfoPtr_Category;

		// Token: 0x04006B8F RID: 27535
		private static readonly IntPtr NativeFieldInfoPtr_Creator;

		// Token: 0x04006B90 RID: 27536
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x04006B91 RID: 27537
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x04006B92 RID: 27538
		private static readonly IntPtr NativeMethodInfoPtr_ApplyValue_Public_Virtual_New_Void_0;

		// Token: 0x04006B93 RID: 27539
		private static readonly IntPtr NativeMethodInfoPtr_WriteValue_Public_Virtual_New_Void_Boolean_0;

		// Token: 0x04006B94 RID: 27540
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
