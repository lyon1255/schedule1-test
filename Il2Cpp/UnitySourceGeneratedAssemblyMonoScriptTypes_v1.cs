using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2Cpp
{
	// Token: 0x0200004A RID: 74
	public class UnitySourceGeneratedAssemblyMonoScriptTypes_v1 : Object
	{
		// Token: 0x06000620 RID: 1568 RVA: 0x000828DC File Offset: 0x00080ADC
		// Note: this type is marked as 'beforefieldinit'.
		static UnitySourceGeneratedAssemblyMonoScriptTypes_v1()
		{
			Il2CppClassPointerStore<UnitySourceGeneratedAssemblyMonoScriptTypes_v1>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "UnitySourceGeneratedAssemblyMonoScriptTypes_v1");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnitySourceGeneratedAssemblyMonoScriptTypes_v1>.NativeClassPtr);
			UnitySourceGeneratedAssemblyMonoScriptTypes_v1.NativeMethodInfoPtr_Get_Private_Static_MonoScriptData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitySourceGeneratedAssemblyMonoScriptTypes_v1>.NativeClassPtr, 100663869);
			UnitySourceGeneratedAssemblyMonoScriptTypes_v1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitySourceGeneratedAssemblyMonoScriptTypes_v1>.NativeClassPtr, 100663870);
		}

		// Token: 0x06000621 RID: 1569 RVA: 0x00082934 File Offset: 0x00080B34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75764, XrefRangeEnd = 75777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get()
		{
			IntPtr* ptr = null;
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(UnitySourceGeneratedAssemblyMonoScriptTypes_v1.NativeMethodInfoPtr_Get_Private_Static_MonoScriptData_0, 0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData(pointer);
		}

		// Token: 0x06000622 RID: 1570 RVA: 0x00082960 File Offset: 0x00080B60
		[CallerCount(2259)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnitySourceGeneratedAssemblyMonoScriptTypes_v1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnitySourceGeneratedAssemblyMonoScriptTypes_v1>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnitySourceGeneratedAssemblyMonoScriptTypes_v1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000623 RID: 1571 RVA: 0x000059B8 File Offset: 0x00003BB8
		public UnitySourceGeneratedAssemblyMonoScriptTypes_v1(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040003A7 RID: 935
		private static readonly IntPtr NativeMethodInfoPtr_Get_Private_Static_MonoScriptData_0;

		// Token: 0x040003A8 RID: 936
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020007C2 RID: 1986
		public sealed class MonoScriptData : ValueType
		{
			// Token: 0x0600BAB6 RID: 47798 RVA: 0x002E4360 File Offset: 0x002E2560
			// Note: this type is marked as 'beforefieldinit'.
			static MonoScriptData()
			{
				Il2CppClassPointerStore<UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnitySourceGeneratedAssemblyMonoScriptTypes_v1>.NativeClassPtr, "MonoScriptData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData>.NativeClassPtr);
				UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData.NativeFieldInfoPtr_FilePathsData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData>.NativeClassPtr, "FilePathsData");
				UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData.NativeFieldInfoPtr_TypesData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData>.NativeClassPtr, "TypesData");
				UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData.NativeFieldInfoPtr_TotalTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData>.NativeClassPtr, "TotalTypes");
				UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData.NativeFieldInfoPtr_TotalFiles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData>.NativeClassPtr, "TotalFiles");
				UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData.NativeFieldInfoPtr_IsEditorOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData>.NativeClassPtr, "IsEditorOnly");
			}

			// Token: 0x0600BAB7 RID: 47799 RVA: 0x0005B617 File Offset: 0x00059817
			public MonoScriptData(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600BAB8 RID: 47800 RVA: 0x0005B620 File Offset: 0x00059820
			public MonoScriptData() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData>.NativeClassPtr))
			{
			}

			// Token: 0x170039AA RID: 14762
			// (get) Token: 0x0600BAB9 RID: 47801 RVA: 0x002E43F0 File Offset: 0x002E25F0
			// (set) Token: 0x0600BABA RID: 47802 RVA: 0x0005B632 File Offset: 0x00059832
			public unsafe Il2CppStructArray<byte> FilePathsData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData.NativeFieldInfoPtr_FilePathsData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData.NativeFieldInfoPtr_FilePathsData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170039AB RID: 14763
			// (get) Token: 0x0600BABB RID: 47803 RVA: 0x002E4420 File Offset: 0x002E2620
			// (set) Token: 0x0600BABC RID: 47804 RVA: 0x0005B651 File Offset: 0x00059851
			public unsafe Il2CppStructArray<byte> TypesData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData.NativeFieldInfoPtr_TypesData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData.NativeFieldInfoPtr_TypesData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170039AC RID: 14764
			// (get) Token: 0x0600BABD RID: 47805 RVA: 0x002E4450 File Offset: 0x002E2650
			// (set) Token: 0x0600BABE RID: 47806 RVA: 0x0005B670 File Offset: 0x00059870
			public unsafe int TotalTypes
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData.NativeFieldInfoPtr_TotalTypes);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData.NativeFieldInfoPtr_TotalTypes)) = value;
				}
			}

			// Token: 0x170039AD RID: 14765
			// (get) Token: 0x0600BABF RID: 47807 RVA: 0x002E4478 File Offset: 0x002E2678
			// (set) Token: 0x0600BAC0 RID: 47808 RVA: 0x0005B68B File Offset: 0x0005988B
			public unsafe int TotalFiles
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData.NativeFieldInfoPtr_TotalFiles);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData.NativeFieldInfoPtr_TotalFiles)) = value;
				}
			}

			// Token: 0x170039AE RID: 14766
			// (get) Token: 0x0600BAC1 RID: 47809 RVA: 0x002E44A0 File Offset: 0x002E26A0
			// (set) Token: 0x0600BAC2 RID: 47810 RVA: 0x0005B6A6 File Offset: 0x000598A6
			public unsafe bool IsEditorOnly
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData.NativeFieldInfoPtr_IsEditorOnly);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData.NativeFieldInfoPtr_IsEditorOnly)) = value;
				}
			}

			// Token: 0x04007DEE RID: 32238
			private static readonly IntPtr NativeFieldInfoPtr_FilePathsData;

			// Token: 0x04007DEF RID: 32239
			private static readonly IntPtr NativeFieldInfoPtr_TypesData;

			// Token: 0x04007DF0 RID: 32240
			private static readonly IntPtr NativeFieldInfoPtr_TotalTypes;

			// Token: 0x04007DF1 RID: 32241
			private static readonly IntPtr NativeFieldInfoPtr_TotalFiles;

			// Token: 0x04007DF2 RID: 32242
			private static readonly IntPtr NativeFieldInfoPtr_IsEditorOnly;
		}
	}
}
