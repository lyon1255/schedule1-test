using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.ConstructableScripts;
using UnityEngine;

namespace Il2CppScheduleOne.Construction.ConstructionMethods
{
	// Token: 0x02000487 RID: 1159
	public class ConstructStart_Base : MonoBehaviour
	{
		// Token: 0x06006492 RID: 25746 RVA: 0x001C6E4C File Offset: 0x001C504C
		// Note: this type is marked as 'beforefieldinit'.
		static ConstructStart_Base()
		{
			Il2CppClassPointerStore<ConstructStart_Base>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Construction.ConstructionMethods", "ConstructStart_Base");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConstructStart_Base>.NativeClassPtr);
			ConstructStart_Base.NativeMethodInfoPtr_StartConstruction_Public_Virtual_New_Void_String_Constructable_GridBased_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructStart_Base>.NativeClassPtr, 100676042);
			ConstructStart_Base.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructStart_Base>.NativeClassPtr, 100676043);
		}

		// Token: 0x06006493 RID: 25747 RVA: 0x001C6EA4 File Offset: 0x001C50A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204316, XrefRangeEnd = 204325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void StartConstruction(string constructableID, Constructable_GridBased movedConstructable = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(constructableID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(movedConstructable);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConstructStart_Base.NativeMethodInfoPtr_StartConstruction_Public_Virtual_New_Void_String_Constructable_GridBased_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006494 RID: 25748 RVA: 0x001C6F04 File Offset: 0x001C5104
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConstructStart_Base() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConstructStart_Base>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructStart_Base.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006495 RID: 25749 RVA: 0x0002F8CD File Offset: 0x0002DACD
		public ConstructStart_Base(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040044A2 RID: 17570
		private static readonly IntPtr NativeMethodInfoPtr_StartConstruction_Public_Virtual_New_Void_String_Constructable_GridBased_0;

		// Token: 0x040044A3 RID: 17571
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
