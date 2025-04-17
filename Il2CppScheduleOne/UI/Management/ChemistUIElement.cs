using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Employees;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Management
{
	// Token: 0x020006D9 RID: 1753
	public class ChemistUIElement : WorldspaceUIElement
	{
		// Token: 0x06009DA4 RID: 40356 RVA: 0x0027DD38 File Offset: 0x0027BF38
		// Note: this type is marked as 'beforefieldinit'.
		static ChemistUIElement()
		{
			Il2CppClassPointerStore<ChemistUIElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Management", "ChemistUIElement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChemistUIElement>.NativeClassPtr);
			ChemistUIElement.NativeFieldInfoPtr_StationsIcons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistUIElement>.NativeClassPtr, "StationsIcons");
			ChemistUIElement.NativeFieldInfoPtr__AssignedChemist_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistUIElement>.NativeClassPtr, "<AssignedChemist>k__BackingField");
			ChemistUIElement.NativeMethodInfoPtr_get_AssignedChemist_Public_get_Chemist_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistUIElement>.NativeClassPtr, 100682631);
			ChemistUIElement.NativeMethodInfoPtr_set_AssignedChemist_Protected_set_Void_Chemist_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistUIElement>.NativeClassPtr, 100682632);
			ChemistUIElement.NativeMethodInfoPtr_Initialize_Public_Void_Chemist_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistUIElement>.NativeClassPtr, 100682633);
			ChemistUIElement.NativeMethodInfoPtr_RefreshUI_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistUIElement>.NativeClassPtr, 100682634);
			ChemistUIElement.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistUIElement>.NativeClassPtr, 100682635);
		}

		// Token: 0x17003090 RID: 12432
		// (get) Token: 0x06009DA5 RID: 40357 RVA: 0x0027DDF4 File Offset: 0x0027BFF4
		// (set) Token: 0x06009DA6 RID: 40358 RVA: 0x0027DE34 File Offset: 0x0027C034
		public unsafe Chemist AssignedChemist
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistUIElement.NativeMethodInfoPtr_get_AssignedChemist_Public_get_Chemist_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Chemist>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistUIElement.NativeMethodInfoPtr_set_AssignedChemist_Protected_set_Void_Chemist_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06009DA7 RID: 40359 RVA: 0x0027DE78 File Offset: 0x0027C078
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 279463, RefRangeEnd = 279464, XrefRangeStart = 279452, XrefRangeEnd = 279463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(Chemist chemist)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(chemist);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistUIElement.NativeMethodInfoPtr_Initialize_Public_Void_Chemist_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009DA8 RID: 40360 RVA: 0x0027DEBC File Offset: 0x0027C0BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 279464, XrefRangeEnd = 279477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RefreshUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChemistUIElement.NativeMethodInfoPtr_RefreshUI_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009DA9 RID: 40361 RVA: 0x0027DEF8 File Offset: 0x0027C0F8
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ChemistUIElement() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChemistUIElement>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistUIElement.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009DAA RID: 40362 RVA: 0x0004D5B4 File Offset: 0x0004B7B4
		public ChemistUIElement(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700308E RID: 12430
		// (get) Token: 0x06009DAB RID: 40363 RVA: 0x0027DF34 File Offset: 0x0027C134
		// (set) Token: 0x06009DAC RID: 40364 RVA: 0x0004D5BD File Offset: 0x0004B7BD
		public unsafe Il2CppReferenceArray<Image> StationsIcons
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistUIElement.NativeFieldInfoPtr_StationsIcons);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Image>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistUIElement.NativeFieldInfoPtr_StationsIcons), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700308F RID: 12431
		// (get) Token: 0x06009DAD RID: 40365 RVA: 0x0027DF64 File Offset: 0x0027C164
		// (set) Token: 0x06009DAE RID: 40366 RVA: 0x0004D5DC File Offset: 0x0004B7DC
		public unsafe Chemist _AssignedChemist_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistUIElement.NativeFieldInfoPtr__AssignedChemist_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Chemist>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistUIElement.NativeFieldInfoPtr__AssignedChemist_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040069D8 RID: 27096
		private static readonly IntPtr NativeFieldInfoPtr_StationsIcons;

		// Token: 0x040069D9 RID: 27097
		private static readonly IntPtr NativeFieldInfoPtr__AssignedChemist_k__BackingField;

		// Token: 0x040069DA RID: 27098
		private static readonly IntPtr NativeMethodInfoPtr_get_AssignedChemist_Public_get_Chemist_0;

		// Token: 0x040069DB RID: 27099
		private static readonly IntPtr NativeMethodInfoPtr_set_AssignedChemist_Protected_set_Void_Chemist_0;

		// Token: 0x040069DC RID: 27100
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_Chemist_0;

		// Token: 0x040069DD RID: 27101
		private static readonly IntPtr NativeMethodInfoPtr_RefreshUI_Protected_Virtual_New_Void_0;

		// Token: 0x040069DE RID: 27102
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
