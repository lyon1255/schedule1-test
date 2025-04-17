using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x0200044D RID: 1101
	public class AstarUtility : MonoBehaviour
	{
		// Token: 0x06005FAC RID: 24492 RVA: 0x001B6F00 File Offset: 0x001B5100
		// Note: this type is marked as 'beforefieldinit'.
		static AstarUtility()
		{
			Il2CppClassPointerStore<AstarUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "AstarUtility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AstarUtility>.NativeClassPtr);
			AstarUtility.NativeMethodInfoPtr_GetClosestPointOnGraph_Public_Static_Vector3_Vector3_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AstarUtility>.NativeClassPtr, 100675504);
			AstarUtility.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AstarUtility>.NativeClassPtr, 100675505);
		}

		// Token: 0x06005FAD RID: 24493 RVA: 0x001B6F58 File Offset: 0x001B5158
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198541, XrefRangeEnd = 198551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 GetClosestPointOnGraph(Vector3 point, string GraphName)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref point;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(GraphName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AstarUtility.NativeMethodInfoPtr_GetClosestPointOnGraph_Public_Static_Vector3_Vector3_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005FAE RID: 24494 RVA: 0x001B6FA8 File Offset: 0x001B51A8
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AstarUtility() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AstarUtility>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AstarUtility.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005FAF RID: 24495 RVA: 0x0002D230 File Offset: 0x0002B430
		public AstarUtility(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04004160 RID: 16736
		private static readonly IntPtr NativeMethodInfoPtr_GetClosestPointOnGraph_Public_Static_Vector3_Vector3_String_0;

		// Token: 0x04004161 RID: 16737
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
