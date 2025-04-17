using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Management.Presets
{
	// Token: 0x020003AC RID: 940
	public class Preset : Il2CppSystem.Object
	{
		// Token: 0x0600497C RID: 18812 RVA: 0x001661BC File Offset: 0x001643BC
		// Note: this type is marked as 'beforefieldinit'.
		static Preset()
		{
			Il2CppClassPointerStore<Preset>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Management.Presets", "Preset");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Preset>.NativeClassPtr);
			Preset.NativeFieldInfoPtr_PresetName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Preset>.NativeClassPtr, "PresetName");
			Preset.NativeFieldInfoPtr_PresetColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Preset>.NativeClassPtr, "PresetColor");
			Preset.NativeFieldInfoPtr_ObjectType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Preset>.NativeClassPtr, "ObjectType");
			Preset.NativeFieldInfoPtr_onNameChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Preset>.NativeClassPtr, "onNameChanged");
			Preset.NativeFieldInfoPtr_onDeleted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Preset>.NativeClassPtr, "onDeleted");
			Preset.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preset>.NativeClassPtr, 100672416);
			Preset.NativeMethodInfoPtr_GetCopy_Public_Abstract_Virtual_New_Preset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preset>.NativeClassPtr, 100672417);
			Preset.NativeMethodInfoPtr_CopyTo_Public_Virtual_New_Void_Preset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preset>.NativeClassPtr, 100672418);
			Preset.NativeMethodInfoPtr_InitializeOptions_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preset>.NativeClassPtr, 100672419);
			Preset.NativeMethodInfoPtr_SetName_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preset>.NativeClassPtr, 100672420);
			Preset.NativeMethodInfoPtr_DeletePreset_Public_Void_Preset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preset>.NativeClassPtr, 100672421);
			Preset.NativeMethodInfoPtr_GetDefault_Public_Static_Preset_ManageableObjectType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preset>.NativeClassPtr, 100672422);
		}

		// Token: 0x0600497D RID: 18813 RVA: 0x001662DC File Offset: 0x001644DC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 163422, RefRangeEnd = 163426, XrefRangeStart = 163417, XrefRangeEnd = 163422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Preset() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Preset>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Preset.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600497E RID: 18814 RVA: 0x00166318 File Offset: 0x00164518
		[CallerCount(0)]
		public unsafe virtual Preset GetCopy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Preset.NativeMethodInfoPtr_GetCopy_Public_Abstract_Virtual_New_Preset_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Preset>(intPtr3) : null;
		}

		// Token: 0x0600497F RID: 18815 RVA: 0x00166364 File Offset: 0x00164564
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 163427, RefRangeEnd = 163428, XrefRangeStart = 163426, XrefRangeEnd = 163427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CopyTo(Preset other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Preset.NativeMethodInfoPtr_CopyTo_Public_Virtual_New_Void_Preset_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004980 RID: 18816 RVA: 0x001663B4 File Offset: 0x001645B4
		[CallerCount(0)]
		public unsafe virtual void InitializeOptions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Preset.NativeMethodInfoPtr_InitializeOptions_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004981 RID: 18817 RVA: 0x001663F0 File Offset: 0x001645F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 163430, RefRangeEnd = 163431, XrefRangeStart = 163428, XrefRangeEnd = 163430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetName(string newName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(newName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Preset.NativeMethodInfoPtr_SetName_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004982 RID: 18818 RVA: 0x00166434 File Offset: 0x00164634
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 163431, RefRangeEnd = 163432, XrefRangeStart = 163431, XrefRangeEnd = 163431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DeletePreset(Preset replacement)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(replacement);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Preset.NativeMethodInfoPtr_DeletePreset_Public_Void_Preset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004983 RID: 18819 RVA: 0x00166478 File Offset: 0x00164678
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 163438, RefRangeEnd = 163439, XrefRangeStart = 163432, XrefRangeEnd = 163438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Preset GetDefault(ManageableObjectType type)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref type;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Preset.NativeMethodInfoPtr_GetDefault_Public_Static_Preset_ManageableObjectType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Preset>(intPtr3) : null;
		}

		// Token: 0x06004984 RID: 18820 RVA: 0x00023636 File Offset: 0x00021836
		public Preset(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001608 RID: 5640
		// (get) Token: 0x06004985 RID: 18821 RVA: 0x001664B8 File Offset: 0x001646B8
		// (set) Token: 0x06004986 RID: 18822 RVA: 0x0002363F File Offset: 0x0002183F
		public unsafe string PresetName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Preset.NativeFieldInfoPtr_PresetName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Preset.NativeFieldInfoPtr_PresetName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001609 RID: 5641
		// (get) Token: 0x06004987 RID: 18823 RVA: 0x001664E0 File Offset: 0x001646E0
		// (set) Token: 0x06004988 RID: 18824 RVA: 0x0002365E File Offset: 0x0002185E
		public unsafe Color32 PresetColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Preset.NativeFieldInfoPtr_PresetColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Preset.NativeFieldInfoPtr_PresetColor)) = value;
			}
		}

		// Token: 0x1700160A RID: 5642
		// (get) Token: 0x06004989 RID: 18825 RVA: 0x00166508 File Offset: 0x00164708
		// (set) Token: 0x0600498A RID: 18826 RVA: 0x00023679 File Offset: 0x00021879
		public unsafe ManageableObjectType ObjectType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Preset.NativeFieldInfoPtr_ObjectType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Preset.NativeFieldInfoPtr_ObjectType)) = value;
			}
		}

		// Token: 0x1700160B RID: 5643
		// (get) Token: 0x0600498B RID: 18827 RVA: 0x00166530 File Offset: 0x00164730
		// (set) Token: 0x0600498C RID: 18828 RVA: 0x00023694 File Offset: 0x00021894
		public unsafe Preset.NameChange onNameChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Preset.NativeFieldInfoPtr_onNameChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Preset.NameChange>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Preset.NativeFieldInfoPtr_onNameChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700160C RID: 5644
		// (get) Token: 0x0600498D RID: 18829 RVA: 0x00166560 File Offset: 0x00164760
		// (set) Token: 0x0600498E RID: 18830 RVA: 0x000236B3 File Offset: 0x000218B3
		public unsafe Preset.PresetDeletion onDeleted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Preset.NativeFieldInfoPtr_onDeleted);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Preset.PresetDeletion>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Preset.NativeFieldInfoPtr_onDeleted), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003193 RID: 12691
		private static readonly IntPtr NativeFieldInfoPtr_PresetName;

		// Token: 0x04003194 RID: 12692
		private static readonly IntPtr NativeFieldInfoPtr_PresetColor;

		// Token: 0x04003195 RID: 12693
		private static readonly IntPtr NativeFieldInfoPtr_ObjectType;

		// Token: 0x04003196 RID: 12694
		private static readonly IntPtr NativeFieldInfoPtr_onNameChanged;

		// Token: 0x04003197 RID: 12695
		private static readonly IntPtr NativeFieldInfoPtr_onDeleted;

		// Token: 0x04003198 RID: 12696
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003199 RID: 12697
		private static readonly IntPtr NativeMethodInfoPtr_GetCopy_Public_Abstract_Virtual_New_Preset_0;

		// Token: 0x0400319A RID: 12698
		private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Virtual_New_Void_Preset_0;

		// Token: 0x0400319B RID: 12699
		private static readonly IntPtr NativeMethodInfoPtr_InitializeOptions_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x0400319C RID: 12700
		private static readonly IntPtr NativeMethodInfoPtr_SetName_Public_Void_String_0;

		// Token: 0x0400319D RID: 12701
		private static readonly IntPtr NativeMethodInfoPtr_DeletePreset_Public_Void_Preset_0;

		// Token: 0x0400319E RID: 12702
		private static readonly IntPtr NativeMethodInfoPtr_GetDefault_Public_Static_Preset_ManageableObjectType_0;

		// Token: 0x02000982 RID: 2434
		public sealed class NameChange : MulticastDelegate
		{
			// Token: 0x0600CA02 RID: 51714 RVA: 0x0030DDE0 File Offset: 0x0030BFE0
			// Note: this type is marked as 'beforefieldinit'.
			static NameChange()
			{
				Il2CppClassPointerStore<Preset.NameChange>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Preset>.NativeClassPtr, "NameChange");
				Preset.NameChange.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preset.NameChange>.NativeClassPtr, 100672423);
				Preset.NameChange.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preset.NameChange>.NativeClassPtr, 100672424);
				Preset.NameChange.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_String_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preset.NameChange>.NativeClassPtr, 100672425);
				Preset.NameChange.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preset.NameChange>.NativeClassPtr, 100672426);
			}

			// Token: 0x0600CA03 RID: 51715 RVA: 0x0030DE54 File Offset: 0x0030C054
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 83960, RefRangeEnd = 83964, XrefRangeStart = 83960, XrefRangeEnd = 83964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe NameChange(Il2CppSystem.Object @object, IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Preset.NameChange>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Preset.NameChange.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CA04 RID: 51716 RVA: 0x0030DEB0 File Offset: 0x0030C0B0
			[CallerCount(0)]
			public unsafe void Invoke(string name)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Preset.NameChange.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CA05 RID: 51717 RVA: 0x0030DEF4 File Offset: 0x0030C0F4
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 74821, RefRangeEnd = 74822, XrefRangeStart = 74821, XrefRangeEnd = 74822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(string name, AsyncCallback callback, Il2CppSystem.Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Preset.NameChange.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_String_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x0600CA06 RID: 51718 RVA: 0x0030DF68 File Offset: 0x0030C168
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 22498, RefRangeEnd = 22499, XrefRangeStart = 22498, XrefRangeEnd = 22499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Preset.NameChange.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CA07 RID: 51719 RVA: 0x000623B4 File Offset: 0x000605B4
			public NameChange(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600CA08 RID: 51720 RVA: 0x000623BD File Offset: 0x000605BD
			public static implicit operator Preset.NameChange(Action<string> A_0)
			{
				return DelegateSupport.ConvertDelegate<Preset.NameChange>(A_0);
			}

			// Token: 0x0600CA09 RID: 51721 RVA: 0x000623C5 File Offset: 0x000605C5
			public static Preset.NameChange operator +(Preset.NameChange A_0, Preset.NameChange A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<Preset.NameChange>();
			}

			// Token: 0x0600CA0A RID: 51722 RVA: 0x000623D3 File Offset: 0x000605D3
			public static Preset.NameChange operator -(Preset.NameChange A_0, Preset.NameChange A_1)
			{
				Delegate result;
				Delegate @delegate = result = Delegate.Remove(A_0, A_1);
				if (@delegate != null)
				{
					result = @delegate.Cast<Preset.NameChange>();
				}
				return result;
			}

			// Token: 0x040088AB RID: 34987
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x040088AC RID: 34988
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_0;

			// Token: 0x040088AD RID: 34989
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_String_AsyncCallback_Object_0;

			// Token: 0x040088AE RID: 34990
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x02000983 RID: 2435
		public sealed class PresetDeletion : MulticastDelegate
		{
			// Token: 0x0600CA0B RID: 51723 RVA: 0x0030DFAC File Offset: 0x0030C1AC
			// Note: this type is marked as 'beforefieldinit'.
			static PresetDeletion()
			{
				Il2CppClassPointerStore<Preset.PresetDeletion>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Preset>.NativeClassPtr, "PresetDeletion");
				Preset.PresetDeletion.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preset.PresetDeletion>.NativeClassPtr, 100672427);
				Preset.PresetDeletion.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Preset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preset.PresetDeletion>.NativeClassPtr, 100672428);
				Preset.PresetDeletion.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Preset_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preset.PresetDeletion>.NativeClassPtr, 100672429);
				Preset.PresetDeletion.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preset.PresetDeletion>.NativeClassPtr, 100672430);
			}

			// Token: 0x0600CA0C RID: 51724 RVA: 0x0030E020 File Offset: 0x0030C220
			[CallerCount(79)]
			[CachedScanResults(RefRangeStart = 106407, RefRangeEnd = 106486, XrefRangeStart = 106407, XrefRangeEnd = 106486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PresetDeletion(Il2CppSystem.Object @object, IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Preset.PresetDeletion>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Preset.PresetDeletion.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CA0D RID: 51725 RVA: 0x0030E07C File Offset: 0x0030C27C
			[CallerCount(0)]
			public unsafe void Invoke(Preset replacement)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(replacement);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Preset.PresetDeletion.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Preset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CA0E RID: 51726 RVA: 0x0030E0C0 File Offset: 0x0030C2C0
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 74821, RefRangeEnd = 74822, XrefRangeStart = 74821, XrefRangeEnd = 74822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IAsyncResult BeginInvoke(Preset replacement, AsyncCallback callback, Il2CppSystem.Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(replacement);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Preset.PresetDeletion.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Preset_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x0600CA0F RID: 51727 RVA: 0x0030E134 File Offset: 0x0030C334
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 22498, RefRangeEnd = 22499, XrefRangeStart = 22498, XrefRangeEnd = 22499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Preset.PresetDeletion.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CA10 RID: 51728 RVA: 0x000623E4 File Offset: 0x000605E4
			public PresetDeletion(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600CA11 RID: 51729 RVA: 0x000623ED File Offset: 0x000605ED
			public static implicit operator Preset.PresetDeletion(Action<Preset> A_0)
			{
				return DelegateSupport.ConvertDelegate<Preset.PresetDeletion>(A_0);
			}

			// Token: 0x0600CA12 RID: 51730 RVA: 0x000623F5 File Offset: 0x000605F5
			public static Preset.PresetDeletion operator +(Preset.PresetDeletion A_0, Preset.PresetDeletion A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<Preset.PresetDeletion>();
			}

			// Token: 0x0600CA13 RID: 51731 RVA: 0x00062403 File Offset: 0x00060603
			public static Preset.PresetDeletion operator -(Preset.PresetDeletion A_0, Preset.PresetDeletion A_1)
			{
				Delegate result;
				Delegate @delegate = result = Delegate.Remove(A_0, A_1);
				if (@delegate != null)
				{
					result = @delegate.Cast<Preset.PresetDeletion>();
				}
				return result;
			}

			// Token: 0x040088AF RID: 34991
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x040088B0 RID: 34992
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Preset_0;

			// Token: 0x040088B1 RID: 34993
			private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Preset_AsyncCallback_Object_0;

			// Token: 0x040088B2 RID: 34994
			private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}
	}
}
